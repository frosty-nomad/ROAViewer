using System.Collections.Generic;
using System.Linq;

namespace Realms
{
    public class RealmsTrap
    {
        public const int OffsetTrap = 132224;
        public const int SizeTrap = 16;

        public string Name { get; set; }
        public string Effect { get; set; }

        public static RealmsTrap GetTrap(List<RealmsTrap> traps, int index)
        {
            return index < traps.Count ? traps[index] : new RealmsTrap();
        }

        public static List<RealmsTrap> LoadTraps(byte[] data)
        {
            var traps = new List<RealmsTrap>();
            var offset = OffsetTrap;
            var curTrap = data.Skip(offset).Take(SizeTrap).ToArray();
            while(curTrap[0] < 32)
            {
                traps.Add(ToTrap(curTrap));
                offset += SizeTrap;
                curTrap = data.Skip(offset).Take(SizeTrap).ToArray();
            }
            return traps;
        }

        private static string GetEffect(byte e)
        {
            switch (e)
            {
                default:
                    return e.ToString();
            }
        }

        private static RealmsTrap ToTrap(byte[] data)
        {
            return new RealmsTrap
            {
                Name = RealmsItem.GetName(1, data, SizeTrap - 1),
                Effect = GetEffect(data[0])
            };
        }
    }
}
