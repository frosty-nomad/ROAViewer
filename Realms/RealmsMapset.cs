using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Realms
{
    public class RealmsMapset
    {
        public const int SizeHeader = 64;

        public int Set { get; set; }
        public List<RealmsMap> Maps { get; set; }
        public List<RealmsTransaction> Transactions { get; set; } = new List<RealmsTransaction>();

        public static RealmsMapset LoadMapset(string dir, int set, RealmsData rData, Action<string> status, bool copy = false)
        {
            var mapset = new RealmsMapset 
            {
                Set = set,
                Maps = LoadMaps(dir, set)
            };

            if (!copy)
            {
                var mData = File.ReadAllBytes($"{dir}\\MB{set}");
                RealmsMobs.ReadMapMobs(mapset, mData, status);

                var tData = File.ReadAllBytes($"{dir}\\MT{set}");
                RealmsTransaction.ReadMapTransactions(tData, mapset, rData, status);
            }

            return mapset;
        }

        private static List<RealmsMap> LoadMaps(string dir, int map)
        {
            var data = File.ReadAllBytes($"{dir}\\MP{map}");
            var mapData = data.Skip(128).ToArray();

            var header = File.ReadAllBytes($"{dir}\\MH{map}");
            var mapHeader = header.Skip(128).ToArray();

            var maps = new List<RealmsMap>();
            var num = 0;
            var offset = 0;
            var curHeader = mapHeader.Skip(offset).Take(SizeHeader).ToArray();
            while (curHeader.Length > 0)
            {
                var curOff = RealmsData.ConvertInt(curHeader[9], curHeader[10]);
                if (curHeader[5] > 0)
                {
                    var rMap = new RealmsMap
                    {
                        Type = (RealmsMapType)curHeader[0],
                        Set = map,
                        Index = num,
                        Info = new RealmsMapInfo {
                            Set = map,
                            Index = num,
                            Name = RealmsMap.DefaultMapName(map, num++)
                        },
                        Charset = RealmsChar.ToCharset(curHeader[1]),
                        Height = curHeader[5],
                        Width = curHeader[7],
                        RDiag = curHeader[11] == 0,
                        LDiag = curHeader[11] == 4,
                        Wrap = curHeader[10] == 1
                    };
                    rMap.Edges = RealmsEdge.LoadEdges(rMap, curHeader);
                    rMap.MapData = mapData.Skip(curOff).Take(rMap.Width * rMap.Height).ToArray();
                    maps.Add(rMap);
                }
                offset += SizeHeader;
                curHeader = mapHeader.Skip(offset).Take(SizeHeader).ToArray();
            }

            return maps;
        }
    }
}
