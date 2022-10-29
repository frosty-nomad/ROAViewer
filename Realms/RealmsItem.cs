using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Realms
{
    public enum RealmsItemType
    {
        Dagger = 128,
        Sword = 129,
        Axe = 130,
        Mace = 131,
        Sword2H = 132,
        Axe2H = 133,
        Mace2H = 134,
        Spear = 135,
        Staff = 136,
        Sling = 137,
        Bow = 138,
        Arbalest = 139,
        Firearm = 140,
        Wand = 141,
        Stones = 142,
        Arrows = 143,
        Quarrels = 144,
        Shot = 145,
        Cloth = 146,
        Leather = 147,
        Hide = 148,
        Mail = 149,
        Plate = 150,
        Shield = 151,
        Foci = 152,
        RadiantPharos = 153,
        Trinket = 154,
        Book = 155,
        SkeletonKey = 156,
        Tool = 157,
        Light = 158,
        Touchstone = 159,
        Scroll = 160,
        Potion = 161,
        EnigmaCube = 162,
        RainbowOrb = 163,
        Rations = 164
    }

    public class RealmsItem
    {
        public const int OffsetItems = 123136;
        public const int OffsetNames = 132480;
        public const int OffsetTypes = 157440;
        public const int SizeItem = 16;
        public const int SizeName = 16;
        public const int SizeNames = 4864;
        public const int SizeType = 16;

        public string Name { get; set; }
        public string TypeName { get; set; }
        public string Effect { get; set; }
        public int Value { get; set; }
        public byte[] Data { get; set; }

        public static RealmsItem Copy(int type, int index, List<RealmsItem> items)
        {
            var isAmmo = IsAmmo(Convert.ToByte(type));
            var item = GetItem(type, isAmmo ? 0 : index & 31, items);
            if (item != null)
            {
                var nItem = new RealmsItem
                {
                    Name = item.Name,
                    TypeName = item.TypeName,
                    Value = item.Value,
                    Data = item.Data.ToArray()
                };
                if (isAmmo)
                {
                    nItem.Data[1] = Convert.ToByte(index);
                }
                return nItem;
            }
            return null;
        }

        public static List<string> DamageTypes(byte b)
        {
            var damages = new List<string>();

            if ((b & 128) == 128)
            {
                damages.Add("B");
            }
            if ((b & 64) == 64)
            {
                damages.Add("S");
            }
            if ((b & 32) == 32)
            {
                damages.Add("P");
            }
            if ((b & 16) == 16)
            {
                damages.Add("F");
            }
            if ((b & 8) == 8)
            {
                damages.Add("C");
            }
            if ((b & 4) == 4)
            {
                damages.Add("E");
            }
            if ((b & 2) == 2)
            {
                damages.Add("M");
            }
            if ((b & 1) == 1)
            {
                damages.Add("A");
            }

            return damages;
        }

        public static string GetEffect(byte b, byte v)
        {
            switch (b)
            {
                case 1:
                    return $"Hlt+{v}";
                case 3:
                    return $"Stm+{v}";
                case 4:
                    return $"M+{v}";
                case 5:
                    return $"R+{v}";
                case 6:
                    return $"Sor+{v}";
                case 7:
                    return $"Def+{v}";
                case 8:
                    return $"Rs+{v}";
                case 9:
                    return $"Lore+{v}";
                case 10:
                    return $"Lock+{v}";
                case 11:
                    return $"Trap+{v}";
                case 12:
                    return $"Gamb+{v}";
                case 13:
                    return $"Crit+{v}";
                case 14:
                    return $"Act+{v}";
                case 15:
                    return $"Mov-1";
                case 16:
                    return $"Red+{v}";
                case 17:
                    return $"Ong+{v}";
                case 18:
                    return $"Yel+{v}";
                case 19:
                    return $"Grn+{v}";
                case 20:
                    return $"Blu+{v}";
                case 21:
                    return $"Igo+{v}";
                case 22:
                    return $"Vio+{v}";
                case 25:
                    return $"mTyp+{string.Join("", DamageTypes(v))}";
                case 26:
                    return $"mDmg+{v}";
                case 30:
                    return $"rTyp+{string.Join("", DamageTypes(v))}";
                case 31:
                    return $"rDmg+{v}";
                case 37:
                    return $"sDmg+{v}";
                case 39:
                    return $"Dmg+{string.Join("", DamageTypes(v))}";
                case 40:
                    return $"Rd+{v}";
                case 42:
                case 43:
                    return $"({EffectType(v)})";
            }
            return b > 0 ? b.ToString() : "";
        }

        public static string EffectType(byte e)
        {
            switch (e)
            {
                case 0:
                    return "Heal";
                case 1:
                    return "Rest";
                case 2:
                    return "Hurt";
                case 3:
                    return "Tire";
                case 4:
                    return "Death";
                case 5:
                    return "Restore";
                case 6:
                    return "Spend";
                case 7:
                    return "GiveMoney";
                case 8:
                    return "Consume";
                case 9:
                    return "GiveFood";
                case 10:
                    return "Cure";
                case 11:
                    return "Calm";
                case 12:
                    return "Awaken";
                case 13:
                    return "Purge";
                case 14:
                    return "Light";
                case 15:
                    return "Stepwatch";
                case 16:
                    return "Stealth";
                case 17:
                    return "Sense";
                case 18:
                    return "Exalt";
                case 19:
                    return "Bane";
                case 20:
                    return "Haste";
                case 21:
                    return "Slow";
                case 22:
                    return "Empower";
                case 23:
                    return "Weaken";
                case 24:
                    return "Regenerate";
                case 25:
                    return "Poison";
                case 26:
                    return "Luck";
                case 27:
                    return "Jinx";
                case 28:
                    return "Protect";
                case 29:
                    return "Acid";
                case 30:
                    return "Blur";
                case 31:
                    return "Confuse";
                case 32:
                    return "Charm";
                case 33:
                    return "Fury";
                case 34:
                    return "Invisible";
                case 35:
                    return "Fear";
                case 36:
                    return "Hold";
                case 37:
                    return "Invinc";
                case 38:
                    return "Mindguard";
                case 39:
                    return "Ward";
                case 40:
                    return "Sleep";
                case 41:
                    return "Enchant";
                case 42:
                    return "Mass Heal";
                case 43:
                    return "Mass Protect";
                case 44:
                    return "Drain";
                case 48:
                    return "Ward";
                case 128:
                    return "Teleport";
                case 130:
                    return "Dispel";
                case 132:
                    return "Magic Eye";
                case 134:
                    return "Reveal";
                case 136:
                    return "Disarm";
                case 138:
                    return "Unlock";
                case 140:
                    return "Scan";
                case 142:
                    return "Summon";
                case 144:
                    return "Guardian";
                case 146:
                    return "IncStr";
                case 148:
                    return "IncAgl";
                case 150:
                    return "IncRea";
                case 152:
                    return "IncCun";
                case 154:
                    return "IncLevel";
                case 156:
                    return "Return";
                case 158:
                    return "Swallow";
                case 160:
                    return "Mark";
                case 162:
                    return "Kismet";
            }

            return e > 0 ? e.ToString() : "";
        }

        public static RealmsItem GetItem(int type, int index, List<RealmsItem> items)
        {
            return items.FirstOrDefault(i => i.Data[0] == type && (IsAmmo((byte)type) || i.Data[1] == index));
        }

        public static string GetName(int offset, byte[] data, int size = SizeName)
        {
            var curOffset = offset;
            var name = "";
            var len = 0;

            while (len < size)
            {
                if (data[curOffset] > 31)
                {
                    name += Convert.ToChar(data[curOffset] & 127);
                    if ((data[curOffset] & 128) == 128)
                    {
                        break;
                    }
                }
                len++;
                curOffset++;
            }

            return name;
        }

        public static byte[] GetNameData(byte[] data)
        {
            return data.Skip(OffsetNames).Take(SizeNames).ToArray();
        }

        public static bool IsAmmo(byte type)
        {
            return IsAmmo(new byte[] { type });
        }

        public static bool IsAmmo(byte[] data)
        {
            var types = new List<RealmsItemType> { RealmsItemType.Stones, RealmsItemType.Arrows, RealmsItemType.Quarrels, RealmsItemType.Shot };
            return types.Contains((RealmsItemType)data[0]);
        }

        public static bool IsArmor(byte[] data)
        {
            var types = new List<RealmsItemType> { RealmsItemType.Cloth, RealmsItemType.Leather, RealmsItemType.Hide, RealmsItemType.Mail, 
                                                   RealmsItemType.Plate, RealmsItemType.Shield, RealmsItemType.Foci  };
            return types.Contains((RealmsItemType)data[0]);
        }

        public static bool IsItem(byte[] data)
        {
            var types = new List<RealmsItemType> { RealmsItemType.Trinket, RealmsItemType.Light, RealmsItemType.Rations,
                                                   RealmsItemType.Scroll, RealmsItemType.Touchstone, RealmsItemType.Tool, RealmsItemType.Potion };
            return types.Contains((RealmsItemType)data[0]);
        }

        public static bool IsMain(byte[] data)
        {
            return IsWeapon(data) && !IsRanged(data);
        }

        public static bool IsWeapon(byte[] data)
        {
            var types = new List<RealmsItemType> { RealmsItemType.Dagger, RealmsItemType.Sword, RealmsItemType.Axe, RealmsItemType.Mace, RealmsItemType.Sword2H, 
                                                   RealmsItemType.Axe2H, RealmsItemType.Mace2H, RealmsItemType.Spear, RealmsItemType.Staff, RealmsItemType.Sling, 
                                                   RealmsItemType.Bow, RealmsItemType.Arbalest, RealmsItemType.Firearm, RealmsItemType.Wand };
            return types.Contains((RealmsItemType)data[0]);
        }

        public static bool IsOffhand(byte[] data)
        {
            return (IsWeapon(data) && (data[5] & 16) == 16) || IsType(RealmsItemType.Shield, data) || IsType(RealmsItemType.Foci, data);
        }

        public static bool IsRanged(byte[] data)
        {
            var types = new List<RealmsItemType> { RealmsItemType.Sling, RealmsItemType.Bow, RealmsItemType.Arbalest, RealmsItemType.Firearm };
            return types.Contains((RealmsItemType)data[0]);
        }

        public static bool IsType(RealmsItemType type, byte[] data)
        {
            return data[0] == (int)type;
        }

        public static string ItemEffect(RealmsItem item, List<RealmsSpell> spells)
        {
            var effect = "";

            if (IsType(RealmsItemType.Trinket, item.Data))
            {
                var effects = new string[]
                {
                    GetEffect(item.Data[4], item.Data[5]),
                    GetEffect(item.Data[6], item.Data[7]),
                    GetEffect(item.Data[8], item.Data[9]),
                    GetEffect(item.Data[10], item.Data[11])
                };
                effect = string.Join(",", effects.Where(s => !string.IsNullOrEmpty(s)));
            }

            if (IsType(RealmsItemType.Light, item.Data))
            {
                effect = $"Rad+{item.Data[6]} Dur+{item.Data[7]}";
            }

            if (IsType(RealmsItemType.Rations, item.Data))
            {
                effect = item.Data[5].ToString();
            }

            if (IsType(RealmsItemType.Scroll, item.Data))
            {
                if (item.Data[4] == 255)
                {
                    effect = $"Cursed! {EffectType(item.Data[7])}";
                }
                else
                {
                    effect = $"Casts { RealmsSpell.SpellName(spells, item.Data[5]) }";
                }
            }

            if (IsType(RealmsItemType.Touchstone, item.Data) || IsType(RealmsItemType.Potion, item.Data))
            {
                effect = $"{EffectType(item.Data[5])} { RealmsData.ConvertInt(item.Data[6], item.Data[7]) }";
            }

            if (IsType(RealmsItemType.Tool, item.Data))
            {
                effect = $"{ RealmsData.ConvertInt(item.Data[4], item.Data[5]) }";
            }

            return effect;
        }

        public static List<RealmsItem> LoadItems(byte[] data, List<RealmsSpell> spells)
        {
            var types = LoadTypes(data);
            var nameData = GetNameData(data);
            var objects = new List<RealmsItem>();
            var curOffset = OffsetItems;
            while (true)
            {
                var b = data.Skip(curOffset).Take(SizeItem).ToArray();
                if (b[0] > 0)
                {
                    var item = new RealmsItem
                    {
                        Name = GetName(RealmsData.ConvertInt(b[14], b[15]), nameData),
                        TypeName = types.ContainsKey(b[0]) ? types[b[0]] : "",
                        Value = RealmsData.ConvertInt(b[2], b[3]),
                        Data = b
                    };
                    item.Effect = ItemEffect(item, spells);
                    objects.Add(item);
                }
                else
                {
                    break;
                }
                curOffset += SizeItem;
            }

            return objects;
        }

        public static Dictionary<int, string> LoadTypes(byte[] data)
        {
            var types = new Dictionary<int, string>();
            var curOffset = OffsetTypes;
            var t = data.Skip(curOffset).Take(SizeType).ToArray();
            while (t[0] > 32)
            {
                types.Add(t[0], Encoding.UTF8.GetString(t.Skip(2).Take(14).ToArray()).Trim());
                curOffset += SizeType;
                t = data.Skip(curOffset).Take(SizeType).ToArray();
            }

            return types;
        }

        public static List<string> Properties(byte[] data)
        {
            var props = new List<string>();

            if (IsWeapon(data) && !IsRanged(data))
            {
                if ((data[5] & 16) == 16)
                {
                    props.Add("Off");
                }
                if ((data[5] & 8) == 8)
                {
                    props.Add("Rch");
                }
                if ((data[5] & 4) == 4)
                {
                    props.Add("Rtn");
                }
                if ((data[5] & 2) == 2)
                {
                    props.Add("Thr");
                }
                if ((data[5] & 1) == 1)
                {
                    props.Add("2Hd");
                }
            }

            if (IsWeapon(data) && IsRanged(data))
            {
                var ammo = data[5] & 3;
                var qty = (data[5] & 252) < 128 ? (data[5] & 252) >> 2 : -1;
                var prop = "";

                prop += qty > -1 ? qty.ToString() : "Inf";

                switch (ammo)
                {
                    case 0:
                        prop += $" Stone{(qty == 1 ? "" : "s")}";
                        break;
                    case 1:
                        prop += $" Arrow{(qty == 1 ? "" : "s")}";
                        break;
                    case 2:
                        prop += $" Quarrel{(qty == 1 ? "" : "s")}";
                        break;
                    case 3:
                        prop += $" Shot{(qty == 1 ? "" : "s")}";
                        break;
                }

                props.Add(prop);
            }

            if (!IsArmor(data))
            {
                var effect = GetEffect(data[10], data[11]);
                if (!string.IsNullOrEmpty(effect))
                {
                    props.Add(effect);
                }
            }

            return props;
        }
    }
}
