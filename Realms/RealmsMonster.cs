using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Realms
{
    public class RealmsMonster
    {
        public const int OffsetMonsters = 128;
        public const int SizeMonsters = 64;

        public int Action { get; set; }
        public string Attack { get; set; }
        public int Coins { get; set; }
        public int Critical { get; set; }
        public string Defense { get; set; }
        public int Experience { get; set; }
        public string Health { get; set; }
        public string Immune { get; set; }
        public int Move { get; set; }
        public string Name { get; set; }
        public string Trait { get; set; }

        public static string Attacks(List<RealmsSpell> spells, byte[] data)
        {
            var attack = "";
            if (data[10] > 0)
            {
                attack += $"Hit+{data[10]}";
            }
            if (data[11] > 0)
            {
                attack += " " + string.Join("", RealmsItem.DamageTypes(data[11]));
            }
            if (data[12] > 0)
            {
                attack += $" {data[12]}-{data[12] + data[13]}";
            }
            if (data[14] > 0)
            {
                attack += $" {RealmsItem.EffectType(data[14])}";
            }
            if (data[15] > 0)
            {
                attack += (attack.Length > 0 ? "/" : "") + $"Rng+{data[15]}";
            }
            if (data[16] > 0)
            {
                attack += " " + string.Join("", RealmsItem.DamageTypes(data[16]));
            }
            if (data[17] > 0)
            {
                attack += $" {data[17]}-{data[17] + data[18]}";
            }
            if (data[19] > 0)
            {
                attack += $" {RealmsItem.EffectType(data[19])}";
            }
            if (data[22] > 0)
            {
                attack += (attack.Length > 0 ? "/" : "") + $"Sor+{data[22]}";
            }
            if (data[23] > 0 && data[23] < spells.Count)
            {
                attack += $" {RealmsSpell.SpellName(spells, data[23])}";
            }
            if (data[24] > 0 && data[24] < spells.Count)
            {
                attack += $",{RealmsSpell.SpellName(spells, data[24])}";
            }
            if (data[25] > 0 && data[25] < spells.Count)
            {
                attack += $",{RealmsSpell.SpellName(spells, data[25])}";
            }

            return attack;
        }

        public static string Defenses(byte[] data)
        {
            var defense = "";
            if (data[27] > 0)
            {
                defense += $"Def+{data[27]} ";
            }
            if (data[26] > 0)
            {
                defense += string.Join("", RealmsItem.DamageTypes(data[26])) + " ";
            }
            if (data[28] > 0)
            {
                defense += $"Rdc+{data[28]} ";
            }
            if (data[29] > 0)
            {
                defense += $"Rst+{data[29]} ";
            }

            return defense;
        }

        public static string Immunes(byte i)
        {
            var immunes = new List<string>();
            if ((i & 128) == 128)
            {
                immunes.Add("Chm");
            }
            if ((i & 64) == 64)
            {
                immunes.Add("Cnf");
            }
            if ((i & 32) == 32)
            {
                immunes.Add("Fear");
            }
            if ((i & 16) == 16)
            {
                immunes.Add("Hold");
            }
            if ((i & 8) == 8)
            {
                immunes.Add("Psn");
            }
            if ((i & 4) == 4)
            {
                immunes.Add("Slp");
            }
            if ((i & 2) == 2)
            {
                immunes.Add("Dth");
            }

            return string.Join(",", immunes);
        }

        public static List<RealmsMonster> LoadMonsters(string dir, List<RealmsSpell> spells)
        {
            var mFileName = $"{dir}\\MND";
            var mData = File.ReadAllBytes(mFileName);

            var monsters = new List<RealmsMonster>();
            var curOffset = OffsetMonsters;
            var monst = mData.Skip(curOffset).Take(SizeMonsters).ToArray();
            while (monst.Length == SizeMonsters)
            {
                monsters.Add(ToMonster(monst, spells));
                curOffset += SizeMonsters;
                monst = mData.Skip(curOffset).Take(SizeMonsters).ToArray();
            }

            return monsters;
        }

        public static RealmsMonster ToMonster(byte[] data, List<RealmsSpell> spells)
        {
            var min = RealmsData.ConvertInt(data[8], data[9]);
            var mod = data[5] & 254;
            return new RealmsMonster
            {
                Name = Encoding.UTF8.GetString(data.Skip(48).Take(16).Select(b => (byte)(b & 127)).ToArray()),
                Health = $"{min}" + (mod > 0 ? $"-{min + mod}" : ""),
                Action = data[32],
                Move = data[33],
                Critical = data[31],
                Experience = RealmsData.ConvertInt(data[6], data[7]),
                Attack = Attacks(spells, data),
                Defense = Defenses(data),
                Immune = Immunes(data[30]),
                Trait = Traits(data[36]),
                Coins = RealmsData.ConvertInt(data[38], data[39])
            };
        }

        public static string Traits(byte t)
        {
            var traits = new List<string>();
            if ((t & 128) == 128)
            {
                traits.Add("Fly");
            }
            if ((t & 64) == 64)
            {
                traits.Add("Pnce");
            }
            if ((t & 32) == 32)
            {
                traits.Add("Smrt");
            }

            return string.Join(",", traits);
        }
    }
}
