using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realms
{
    public class RealmsTransaction
    {
        public const int ByteBoundry = 32;
        public const int OffsetTrans = 128;

        public int Set { get; set; }
        public int Sector { get; set; }
        public int Offset { get; set; }
        public List<RealmsInstruction> Instructions { get; set; }

        public static string GetDisassembly(int sector, int offset, RealmsMapset mapset)
        {
            var trans = mapset.Transactions.FirstOrDefault(t => t.Sector == sector && t.Offset == offset);
            return trans != null ? trans.Disassemble() : "";
        }

        public static void ReadMapTransactions(byte[] data, RealmsMapset mapset, RealmsData rData, Action<string> status)
        {
            foreach (var map in mapset.Maps)
            {
                if (map.Type != RealmsMapType.Travel)
                {
                    status($"Loading Transaction Information: Set{map.Set}-Map{map.Index}...");
                    
                    foreach(var mob in map.Mobs.Mobs.Where(m => m.Type == RealmsMobType.Transaction || m.Type == RealmsMobType.NTransaction))
                    {
                        mapset.Transactions.Add(LoadTransaction(data, map.Set, mob.Sector, mob.Data[1], rData));
                    }
                }
            }
        }

        private static List<RealmsInstruction> BuildInstructions(byte[] data, RealmsData rData)
        {
            var branches = new List<int>();
            var insts = new List<RealmsInstruction>();

            var more = true;
            var offset = 0;
            var line = 0;

            while (more)
            {
                insts.AddRange(ReadInstructions(data, ref offset, ref line, branches, rData));
                more = branches.Contains(line);
            };

            return insts;
        }

        private string Disassemble()
        {
            var dis = "";
            foreach (var inst in Instructions)
            {
                var bCount = inst.Branches.Count;
                var sCount = inst.Texts.Count;
                dis += $"{inst}";
                if (sCount == 1)
                {
                    dis += $" {inst.Texts[0]}{(bCount != 1 ? "\r\n" : "")}";
                }
                if (bCount == 1)
                {
                    dis += $" B:{inst.Branches[0]:000}\r\n";
                }

                if (sCount > 1)
                {
                    var count = 0;
                    dis += " {\r\n";
                    foreach (var s in inst.Texts)
                    {
                        dis += $"{s}{(bCount > count ? $" B:{inst.Branches[count]:000}" : "")}\r\n";
                        count++;
                    }
                    dis += "}\r\n";
                }

                if (sCount == 0 && bCount == 0)
                {
                    dis += "\r\n";
                }
            }
            return dis;
        }

        private static RealmsTransaction LoadTransaction(byte[] data, int set, int sector, int offset, RealmsData rData)
        {
            var dOffset = RealmsSector.CalcDataOffset(sector, offset);
            return new RealmsTransaction
            {
                Set = set,
                Sector = sector,
                Offset = offset,
                Instructions = BuildInstructions(data.Skip(dOffset + OffsetTrans).ToArray(), rData)
            };
        }

        private static List<RealmsInstruction> ReadInstructions(byte[] data, ref int offset, ref int line, List<int> branches, RealmsData rData)
        {
            var trans = new List<RealmsInstruction>();
            var inst = new RealmsInstruction { Type = RealmsInstType.Title };
            while (inst.Type != RealmsInstType.End)
            {
                inst = RealmsInstruction.GetInstruction(data, offset, line, rData);
                branches.AddRange(inst.Branches);
                trans.Add(inst);

                offset += inst.Length;
                line += inst.Lines;
            }
            return trans;
        }
    }
}
