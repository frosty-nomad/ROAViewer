using System;
using System.Collections.Generic;
using System.Linq;

namespace Realms
{
    public class RealmsSpell
    {
        public const int OffsetSpells = 128128;
        public const int OffsetNames = 137344;
        public const int SizeNames = 2048;
        public const int SizeSpell = 16;

        public string Color { get; set; }
        public int Cost { get; set; }
        public string DamageType { get { return string.Join("", DamageTypes); } }
        public List<string> DamageTypes { get; set; }
        public string Effect { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Power2 { get; set; }
        public string Type { get; set; }
        public string Special { get; set; }

        public static List<RealmsSpell> LoadSpells(byte[] data)
        {
            var nameData = GetNameData(data);
            var spells = new List<RealmsSpell>();
            var curOffset = OffsetSpells;
            while (true)
            {
                var b = data.Skip(curOffset).Take(SizeSpell).ToArray();
                if (b[0] > 0)
                {
                    spells.Add(new RealmsSpell
                    {
                        Name = RealmsItem.GetName(RealmsData.ConvertInt(b[14], b[15]), nameData),
                        Color = SpellColor(b[1]),
                        Cost = b[2],
                        DamageTypes = RealmsItem.DamageTypes(b[3]),
                        Power2 = b[4],
                        Power = b[5],
                        Effect = $"{RealmsItem.EffectType(b[9])} {(b[5] > 0 ? b[5].ToString() : b[4] > 0 ? b[4].ToString() : "")}",
                        Special = RealmsData.ConvertInt(b[12], b[13]).ToString()
                    });
                }
                else
                {
                    break;
                }
                curOffset += SizeSpell;
            }

            return spells;
        }

        public static string SpellName(List<RealmsSpell> spells, byte s)
        {
            return spells.Count > s ? spells[s].Name : s.ToString();
        }

        private static byte[] GetNameData(byte[] data)
        {
            return data.Skip(OffsetNames).Take(SizeNames).ToArray();
        }

        private static string SpellColor(byte a)
        {
            switch (a)
            {
                case 1:
                    return "Red";
                case 2:
                    return "Orange";
                case 3:
                    return "Yellow";
                case 4:
                    return "Green";
                case 5:
                    return "Blue";
                case 6:
                    return "Indigo";
                case 7:
                    return "Violet";
            }
            return "";
        }
    }
}
