using System.Collections.Generic;
using System.IO;

namespace Realms
{
    public class RealmsParty
    {
        public static string FileName = "SAV";
        public const int OffsetParty = 128;

        public byte[] Data { get; set; }
        public int Light { get; set; }
        public int LightInt { get; set; }
        public int MapIndex { get; set; }
        public int Mapset { get; set; }
        public int Money { get; set; }
        public List<RealmsPlayer> Players { get; set; }
        public int Rations { get; set; }
        public int Stepwatch { get; set; }
        public int Stealth { get; set; }
        public int Sense { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public static RealmsParty LoadParty(string dir, List<string> states, List<RealmsItem> items)
        {
            var fileName = $"{dir}\\{FileName}";
            var data = File.ReadAllBytes(fileName);

            return new RealmsParty
            {
                Data = data,
                Money = RealmsData.ConvertInt(data[OffsetParty + 0], data[OffsetParty + 1]),
                Rations = RealmsData.ConvertInt(data[OffsetParty + 2], data[OffsetParty + 3]),
                Mapset = data[OffsetParty + 4],
                MapIndex = data[OffsetParty + 5],
                Y = RealmsData.ConvertInt(data[OffsetParty + 6], data[OffsetParty + 7]),
                X = RealmsData.ConvertInt(data[OffsetParty + 8], data[OffsetParty + 9]),
                Light = data[OffsetParty + 10],
                Stepwatch = data[OffsetParty + 11],
                Stealth = data[OffsetParty + 12],
                Sense = data[OffsetParty + 13],
                LightInt = data[OffsetParty + 15],
                Players = LoadPlayers(data, states, items)
            };
        }

        public static void SaveParty(RealmsParty party, string dir)
        {
            BackupFile(dir);

            RealmsData.UpdateData(party.Data, OffsetParty + 0, party.Money, 2);
            RealmsData.UpdateData(party.Data, OffsetParty + 2, party.Rations, 2);
            RealmsData.UpdateData(party.Data, OffsetParty + 4, party.Mapset);
            RealmsData.UpdateData(party.Data, OffsetParty + 5, party.MapIndex);
            RealmsData.UpdateData(party.Data, OffsetParty + 6, party.Y, 2);
            RealmsData.UpdateData(party.Data, OffsetParty + 8, party.X, 2);
            RealmsData.UpdateData(party.Data, OffsetParty + 10, party.Light);
            RealmsData.UpdateData(party.Data, OffsetParty + 11, party.Stepwatch);
            RealmsData.UpdateData(party.Data, OffsetParty + 12, party.Stealth);
            RealmsData.UpdateData(party.Data, OffsetParty + 13, party.Sense);
            RealmsData.UpdateData(party.Data, OffsetParty + 15, party.LightInt);

            for (var p = 0; p < party.Players.Count; p++)
            {
                RealmsPlayer.UpdatePlayer(party.Data, p, party.Players[p]);
            }

            File.WriteAllBytes($"{dir}\\SAV", party.Data);
        }

        private static void BackupFile(string dir)
        {
            var count = 0;
            var saved = false;
            while (!saved)
            {
                try
                {
                    File.Copy($"{dir}\\SAV", $"{dir}\\SAV.BAK{count++}");
                    saved = true;
                }
                catch
                {
                }
            }
        }

        private static List<RealmsPlayer> LoadPlayers(byte[] data, List<string> states, List<RealmsItem> items)
        {
            var players = new List<RealmsPlayer>();

            for (var p = 0; p < 4; p++)
            {
                var player = RealmsPlayer.LoadPlayer(data, p, states, items);
                if (player != null)
                {
                    players.Add(player);
                }
            }

            return players;
        }
    }
}
