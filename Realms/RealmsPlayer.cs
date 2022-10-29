using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Realms
{
    public class RealmsPlayer
    {
        public const int OffsetName = 448;
        public const int OffsetPlayer = 192;
        public const int OffsetStates = 556;

        public const int SizeName = 16;
        public const int SizeStates = 32;
        public const int SizePlayer = 64;

        public byte[] Data { get; set; }
        public string Name { get; set; }

        public RealmsHealth Health { get; set; }
        public RealmsInventory Inventory { get; set; }
        public RealmsStats Stats { get; set; }
        public List<RealmsState> States { get; set; }

        public static RealmsPlayer LoadPlayer(byte[] data, int index, List<string> states, List<RealmsItem> items)
        {
            var pName = data.Skip(OffsetName + (index * SizeName)).Take(SizeName).Select(c => (byte)(c & 127)).ToArray();
            if (pName[0] > 0)
            {
                return new RealmsPlayer
                {
                    Data = data,
                    Health = RealmsHealth.LoadHealth(data, index),
                    Inventory = RealmsInventory.LoadInventory(data, index, items),
                    Name = Encoding.Default.GetString(pName),
                    States = LoadStates(data, index, states),
                    Stats = RealmsStats.LoadStats(data, index),
                };
            }
            else
            {
                return null;
            }
        }

        public static List<RealmsState> LoadStates(byte[] data, int index, List<string> descs)
        {
            var desc = 0;
            var offset = OffsetStates + (index * SizeStates);
            var states = new List<RealmsState>();

            for (var s = 0; s < descs.Count; s++)
            {
                states.Add(new RealmsState { Description = descs[desc++], Value = data[offset++] });
            }

            return states;
        }

        public static void UpdatePlayer(byte[] data, int index, RealmsPlayer player)
        {
            var offName = OffsetName + (index * 16);

            RealmsData.UpdateData(data, offName, FormatName(player.Name).ToCharArray());
            RealmsHealth.UpdateHealth(data, index, player.Health);
            RealmsInventory.UpdateInventory(data, index, player.Inventory);
            RealmsStats.UpdateStats(data, index, player.Stats);
            UpdateStates(data, index, player.States);
        }

        private static string FormatName(string name)
        {
            var newName = name.PadRight(16).ToCharArray();
            var last = false;
            for (var c = newName.Length - 1; c > -1; c--)
            {
                var a = Convert.ToByte(newName[c]);
                if (!last && a > 32)
                {
                    newName[c] = Convert.ToChar((byte)(a | 128));
                    last = true;
                }
            }
            return new string(newName);
        }

        private static void UpdateStates(byte[] data, int index, List<RealmsState> states)
        {
            var count = 0;
            var offset = OffsetStates + (index * SizeStates);

            for (var s = 0; s < 24; s++)
            {
                RealmsData.UpdateData(data, offset + s, states[count++].Value);
            }
        }
    }
}
