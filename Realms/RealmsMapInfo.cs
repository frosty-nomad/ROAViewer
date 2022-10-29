using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Realms
{
    public class RealmsMapInfo
    {
        public int Set { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public List<RealmsInfo> Info { get; set; } = new List<RealmsInfo>();
        [JsonIgnore]
        public List<RealmsInfo> MobInfo { get; set; } = new List<RealmsInfo>();
        public bool AutoMob { get; set; }

        public RealmsMapInfo Copy()
        {
            return new RealmsMapInfo
            {
                Set = Set,
                Index = Index,
                Name = Name,
                Info = Info.Select(i => i.Copy(i.MobGen)).ToList(),
                MobInfo = MobInfo.Select(i => i.Copy(i.MobGen)).ToList()
            };
        }

        public static void DeleteMapInfo(RealmsInfo info, RealmsMap map, RealmsMaps maps)
        {
            if (!info.MobGen)
            {
                map.Info.Info.Remove(info);
            }
        }

        public static RealmsInfo GetInfo(int x, int y, RealmsMapInfo mapInfo, RealmsOptions options)
        {
            var info = mapInfo.Info.FirstOrDefault(i => i.X == x && i.Y == y);
            if (info == null)
            {
                info = mapInfo.MobInfo.FirstOrDefault(i => i.X == x && i.Y == y && options.GetShowInfo(i.Type));
            }
            return info;
        }

        public static void LoadMapInfo(string dir, string fileName, RealmsMaps maps)
        {
            try
            {
                var data = File.ReadAllText($"{dir}\\{fileName}");
                var info = JsonSerializer.Deserialize<List<RealmsMapInfo>>(data);
                var check = info.FirstOrDefault(i => i.Index > 0);
                var nInfo = check == null ? ConvertOldInfo(info, maps) : info;
                foreach (var map in maps.Mapsets.SelectMany(m => m.Maps))
                {
                    var mInfo = info.FirstOrDefault(i => i.Set == map.Set && i.Index == map.Index);
                    map.Info = mInfo != null ? mInfo : map.Info;
                }
            }
            catch
            {
            }
        }

        public static DateTime SaveMapInfo(string dir, string fileName, RealmsMaps maps)
        {
            var infos = new List<RealmsMapInfo>();
            foreach (var map in maps.Mapsets.SelectMany(m => m.Maps))
            {
                var mInfo = map.Info.Copy();
                if (mInfo.Name != RealmsMap.DefaultMapName(map.Set, map.Index) || mInfo.Info.Count > 0)
                {
                    infos.Add(mInfo);
                }
            }
            var info = JsonSerializer.Serialize(infos);
            File.WriteAllText($"{dir}\\{fileName}", info);
            return File.GetLastWriteTime($"{dir}\\{fileName}");
        }

        private static List<RealmsMapInfo> ConvertOldInfo(List<RealmsMapInfo> info, RealmsMaps maps)
        {
            var newInfos = new List<RealmsMapInfo>();
            var index = 0;
            foreach(var map in maps.Mapsets.SelectMany(m => m.Maps))
            {
                var mInfo = info[index];
                if (mInfo.Info != null && (mInfo.Name != RealmsMap.DefaultMapName(map.Set, map.Index) || mInfo.Info.Count > 0))
                {
                    newInfos.Add(new RealmsMapInfo
                    {
                        Set = map.Set,
                        Index = map.Index,
                        Name = mInfo.Name,
                        Info = mInfo.Info
                    });
                }
                index++;
            }
            return newInfos;
        }
    }
}
