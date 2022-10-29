using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Realms
{
    public enum RealmsClassType
    {
        [Description("Branimir")]
        Branimir,
        [Description("Doran")]
        Doran,
        [Description("Flynn")]
        Flynn,
        [Description("Giles")]
        Giles,
        [Description("Tharon")]
        Tharon,
        [Description("Ket")]
        Ket,
        [Description("Layla")]
        Layla,
        [Description("Bahadur")]
        Bahadur
    }

    public enum RealmsSkillType
    {
        [Description("Melee")]
        Melee = 10,
        [Description("Ranged")]
        Ranged = 11,
        [Description("Sorcery")]
        Sorcery = 12,
        [Description("Defense")]
        Defense = 13,
        [Description("Resist")]
        Resist = 14,
        [Description("Lore")]
        Lore = 15,
        [Description("Unlock")]
        Unlock = 16,
        [Description("Disarm")]
        Disarm = 17,
        [Description("Gamble")]
        Gamble = 18,
        [Description("Critical")]
        Critical = 19,
        [Description("Red Magic")]
        RedSorcery = 22,
        [Description("Orange Magic")]
        OrangeSorcery = 23,
        [Description("Yellow Magic")]
        YellowSorcery = 24,
        [Description("Green Magic")]
        GreenSorcery = 25,
        [Description("Blue Magic")]
        BlueSorcery = 26,
        [Description("Indigo Magic")]
        IndigoSorcery = 27,
        [Description("Violet Magic")]
        VioletSorcery = 28
    }

    public class RealmsData
    {
        public List<RealmsArmor> Armor { get; set; }
        public List<RealmsChar> Chars { get; set; }
        public List<string> Classes { get; set; }
        public List<RealmsItem> Items { get; set; }
        public List<RealmsMonster> Monsters { get; set; }
        public RealmsOptions Options { get; set; }
        public RealmsParty Party { get; set; }
        public byte[] PData { get; set; }
        public List<RealmsQuest> Quests { get; set; }
        public List<RealmsSpell> Spells { get; set; }
        public List<RealmsSpellbook> Spellbooks { get; set; }
        public List<RealmsTrap> Traps { get; set; }
        public Dictionary<int, string> Types { get; set; }
        public List<RealmsWeapon> Weapons { get; set; }

        public RealmsChar GetChar(int set, int index)
        {
            var cIndex = (set * RealmsChar.CountCharset) + index;
            return cIndex < Chars.Count ? Chars[cIndex] : null;
        }

        public List<SpellbookRow> ToSpellbookRows()
        {
            var rows = new List<SpellbookRow>();

            foreach (var r in Spellbooks)
            {
                rows.AddRange(r.ToSpellbookRows());
            }

            return rows;
        }

        public static int ConvertInt(byte a, byte b)
        {
            return a << 8 | b;
        }
        
        public static List<string> LoadClasses()
        {
            return new List<string>
            {
                "Hero",
                "Crusader",
                "Wizard",
                "Ranger",
                "Paladin",
                "Warlock",
                "Bard",
                "Fighter",
                "Rogue"
            };
        }

        public static RealmsData LoadData(string dir, int pixelSize, bool showGrid, int shading)
        {
            try
            {
                var pFileName = $"{dir}\\PRG";
                var pData = File.ReadAllBytes(pFileName);

                var options = new RealmsOptions(pixelSize, showGrid, shading);
                var spells = RealmsSpell.LoadSpells(pData);
                var items = RealmsItem.LoadItems(pData, spells);

                return new RealmsData
                {
                    Armor = items.Where(i => RealmsItem.IsArmor(i.Data)).Select(i => RealmsArmor.ToArmor(i)).ToList(),
                    Chars = RealmsChar.LoadChars(dir, options),
                    Classes = LoadClasses(),
                    Monsters = RealmsMonster.LoadMonsters(dir, spells),
                    Options = options,
                    Quests = RealmsQuest.LoadNames(pData),
                    Spells = RealmsSpell.LoadSpells(pData),
                    Spellbooks = RealmsSpellbook.LoadSpellbooks(items, spells),
                    Items = items,
                    Party = RealmsParty.LoadParty(dir, RealmsState.LoadStates(pData), items),
                    PData = pData,
                    Traps = RealmsTrap.LoadTraps(pData),
                    Types = RealmsItem.LoadTypes(pData),
                    Weapons = items.Where(i => RealmsItem.IsWeapon(i.Data)).Select(i => RealmsWeapon.ToWeapon(i)).ToList()
                };
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateData(byte[] data, int offset, int value, int length = 1)
        {
            var newValue = length == 2 ? BitConverter.GetBytes((short)value) : new byte[] { (byte)value };
            for (var o = length - 1; o > -1; o--)
            {
                data[offset++] = newValue[o];
            }
        }

        public static void UpdateData(byte[] data, int offset, char[] value)
        {
            for (var o = 0; o < value.Length; o++)
            {
                data[offset++] = Convert.ToByte(value[o]);
            }
        }
    }
}
