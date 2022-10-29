using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Realms
{
    public enum RealmsInfoType
    {
        [Description("Map")]
        Map,
        [Description("Information")]
        Info,
        [Description("Vendor")]
        Vendor,
        [Description("NPC")]
        NPC,
        [Description("Quest")]
        Quest,
        [Description("Chest")]
        Chest,
        [Description("Monster")]
        Monster,
        [Description("Secret")]
        Secret,
        [Description("Boat")]
        Boat,
        [Description("Locked Door")]
        Door,
        [Description("Trap")]
        Trap,
        [Description("Pit Trap")]
        PitTrap,
        [Description("Marker")]
        Marker
    }

    [Serializable]
    public class RealmsInfo
    {
        public bool MobGen { get; set; }
        public int MapIndex { get; set; }
        public int Mapset { get; set; }
        public int MapX { get; set; }
        public int MapY { get; set; }
        public string Notes { get; set; }
        public RealmsInfoType Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public RealmsInfo Copy(bool mobGen = false)
        {
            return new RealmsInfo
            {
                MobGen = mobGen,
                MapIndex = MapIndex,
                Mapset = Mapset,
                MapX = MapX,
                MapY = MapY,
                Notes = Notes,
                Type = Type,
                X = X,
                Y = Y
            };
        }

        public static bool IsMapInfo(RealmsInfoType type)
        {
            return new List<RealmsInfoType> { RealmsInfoType.Map, RealmsInfoType.PitTrap }.Contains(type);
        }
    }
}
