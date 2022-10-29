using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Realms
{
    public enum RealmsMobType
    {
        [Description("Empty")]
        Empty,
        [Description("Monster")]
        Monster,
        [Description("Information")]
        Information,
        [Description("Transaction")]
        Transaction,
        [Description("MonsterGuard")]
        MonsterGuard,
        [Description("NInformation")]
        NInformation,
        [Description("NTransaction")]
        NTransaction,
        [Description("ExitToLocal")]
        ExitToLocal,
        [Description("ExitToMap")]
        ExitToMap,
        [Description("LockedDoor")]
        LockedDoor,
        [Description("Chest")]
        Chest,
        [Description("Boat")]
        Boat,
        [Description("Switch")]
        Switch,
        [Description("SpaceDoor")]
        SpaceDoor,
        [Description("Block")]
        Block,
        [Description("SwitchSpace")]
        SwitchSpace,
        [Description("MonsterAmbush")]
        MonsterAmbush,
        [Description("Incidental")]
        Incidental,
        [Description("SecretPassage")]
        SecretPassage,
        [Description("Trap")]
        Trap,
        [Description("PitTrap")]
        PitTrap,
        [Description("MobTrigger")]
        MobTrigger,
        [Description("TileTrigger")]
        TileTrigger,
        [Description("InertMob")]
        InertMob
    }

    public class RealmsMob
    {
        public const int SizeMob = 8;

        public RealmsMobType Type { get; set; }
        public int Char { get; set; }
        public int Y { get; set; }
        public int X { get; set; }
        public int Sector { get; set; }
        public byte[] Data { get; set; }

        public static string ChestNotes(RealmsMob mob, RealmsData rData)
        {
            var type = mob.Data[1];
            var value = "";
            switch (type)
            {
                case 0:
                    value = "Empty";
                    break;
                case 2:
                    var b = mob.Data[2];
                    var r = mob.Data[2] + mob.Data[3];
                    value = $"{(b == 0 ? r.ToString() : $"{b}-{r}")} Coins";
                    break;
                case 4:
                    var obj = RealmsItem.GetItem(mob.Data[2], mob.Data[3] & 127, rData.Items);
                    value = obj != null ? obj.Name : $"{mob.Data[2]},{mob.Data[3]}";
                    break;
                case 6:
                    value = $"Quest Item - { rData.Quests[mob.Data[3]].Name }";
                    break;
            }

            return $"Chest ({mob.Data[0]}) - {value}";
        }

        public static string MonsterNotes(RealmsMob mob, RealmsMobs mobs, RealmsData rData)
        {
            var notes = "";
            var texts = RealmsMobs.GetMobTexts(mob, mobs.Texts, rData);

            switch (mob.Type)
            {
                case RealmsMobType.Monster:
                case RealmsMobType.MonsterAmbush:
                case RealmsMobType.MonsterGuard:
                    if (!string.IsNullOrEmpty(texts[1]))
                    {
                        notes += $"{texts[1]}\r\n\r\n";
                    }
                    notes += $"{(mob.Type == RealmsMobType.MonsterAmbush ? "Ambush - " : "")}";
                    notes += mob.Data[2] == 0 ? "Random " : $"{mob.Data[2]} ";
                    notes += $"{texts[3].Trim()}{(mob.Data[2] == 1 ? "" : "s")}";
                    break;
            }

            return notes;
        }

        public static bool IsMapMob(RealmsMob mob)
        {
            return (mob.X != 0 || mob.Y != 0) && mob.Char < 248;
        }

        public static RealmsChar GetChar(RealmsMob mob, int charset, RealmsData rData)
        {
            return rData.GetChar(charset, mob.Char & 127);
        }

        public static RealmsMob ReadMob(byte[] data, ref int offset)
        {
            var mData = data.Skip(offset).Take(SizeMob).ToArray();
            offset += SizeMob;
            var mob = new RealmsMob
            {
                Type = (RealmsMobType)mData[0],
                Char = mData[1],
                Y = mData[2],
                X = mData[3],
                Data = mData.Skip(4).ToArray(),
            };
            if (mob.Type == RealmsMobType.Transaction || mob.Type == RealmsMobType.NTransaction)
            {
                mob.Sector = RealmsSector.CalcSector(mob.Data[2], mob.Data[3]);
            }
            return mob;
        }
    }
}
