using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Realms
{
    public class RealmsMaps
    {
        public List<RealmsMapset> Mapsets { get; set; } = new List<RealmsMapset>();

        public RealmsMap GetMap(int set, int index, RealmsData rData)
        {
            var map = Mapsets[set].Maps[index];
            RealmsMobs.BuildMobsInfo(map, Mapsets[set], rData);
            return map;
        }

        public static RealmsMaps LoadMaps(string dir, RealmsData rData, bool copy, Action<string> status, string infoFile = null)
        {
            var maps = new RealmsMaps
            {
                Mapsets = new List<RealmsMapset>
                {
                    RealmsMapset.LoadMapset(dir, 0, rData, status, copy),
                    RealmsMapset.LoadMapset(dir, 1, rData, status, copy),
                    RealmsMapset.LoadMapset(dir, 2, rData, status, copy),
                    RealmsMapset.LoadMapset(dir, 3, rData, status, copy)
                }
            };
            if (!copy && infoFile != null)
            {
                RealmsMapInfo.LoadMapInfo(dir, infoFile, maps);
            }
            return maps;
        }
    }
}
