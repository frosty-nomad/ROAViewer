using System.Collections.Generic;
using System.Linq;

namespace Realms
{
    public class RealmsQuest
    {
        public const int OffsetNames = 131200;
        public const int SizeName = 16;
        public const int CountNames = 64;

        public string Name { get; set; }

        public static List<RealmsQuest> LoadNames(byte[] data)
        {
            var names = new List<RealmsQuest>();
            var offset = OffsetNames;
            for (var n = 0; n < CountNames; n++)
            {
                var name = data.Skip(offset).Take(SizeName).ToArray();
                names.Add(new RealmsQuest { Name = RealmsItem.GetName(0, name, SizeName) });
                offset += SizeName;
            }
            return names;
        }
    }
}
