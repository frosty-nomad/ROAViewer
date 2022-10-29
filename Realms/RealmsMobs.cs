using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Realms
{
    public class RealmsMobs
    {
        public const int ByteBoundry = 16;
        public const int OffsetMobs = 128;
        public const int SizeHeader = 2;

        public List<RealmsMob> Mobs { get; set; } = new List<RealmsMob>();
        public List<RealmsText> Texts { get; set; } = new List<RealmsText>();

        public static void BuildMobsInfo(RealmsMap map, RealmsMapset mapset, RealmsData rData)
        {
            if (!map.Info.AutoMob)
            {
                map.Info.AutoMob = true;
                foreach(var mob in map.Mobs.Mobs)
                {
                    var add = false;
                    var info = new RealmsInfo
                    {
                        MobGen = true,
                        X = mob.X,
                        Y = mob.Y,
                    };
                    switch (mob.Type)
                    {
                        case RealmsMobType.NInformation:
                            var texts = GetMobTexts(mob, map.Mobs.Texts, rData);
                            if (!string.IsNullOrEmpty(texts[1]))
                            {
                                info.Type = RealmsInfoType.Info;
                                info.Notes = texts[1];
                                add = true;
                            }
                            break;

                        case RealmsMobType.Boat:
                            info.Type = RealmsInfoType.Boat;
                            add = true;
                            break;

                        case RealmsMobType.Chest:
                            info.Type = mob.Data[1] == 6 ? RealmsInfoType.Quest : RealmsInfoType.Chest;
                            info.Notes = RealmsMob.ChestNotes(mob, rData);
                            add = true;
                            break;

                        case RealmsMobType.ExitToMap:
                        case RealmsMobType.ExitToLocal:
                            info.Type = RealmsInfoType.Map;
                            info.Mapset = mob.Type == RealmsMobType.ExitToMap ? mob.Data[0] : map.Set;
                            info.MapIndex = mob.Type == RealmsMobType.ExitToMap ? mob.Data[1] : map.Index;
                            info.MapX = mob.Data[3];
                            info.MapY = mob.Data[2];
                            add = true;
                            break;

                        case RealmsMobType.LockedDoor:
                            info.Type = RealmsInfoType.Door;
                            info.Notes = $"Locked Door ({ mob.Data[0] })";
                            add = true;
                            break;

                        case RealmsMobType.Monster:
                        case RealmsMobType.MonsterAmbush:
                        case RealmsMobType.MonsterGuard:
                            info.Type = RealmsInfoType.Monster;
                            info.Notes = RealmsMob.MonsterNotes(mob, map.Mobs, rData);
                            add = true;
                            break;

                        case RealmsMobType.Transaction:
                        case RealmsMobType.NTransaction:
                            var trans = mapset.Transactions.FirstOrDefault(t => t.Sector == mob.Sector && t.Offset == mob.Data[1]);
                            if (trans != null)
                            {
                                var notes = GetVendorNotes(trans);
                                if (notes.Length > 0)
                                {
                                    info.Type = RealmsInfoType.Vendor;
                                    info.Notes = GetVendorNotes(trans);
                                    add = true;
                                }
                            }
                            break;

                        case RealmsMobType.SecretPassage:
                            info.Type = RealmsInfoType.Secret;
                            info.Notes = "Secret Passage";
                            add = true;
                            break;

                        case RealmsMobType.TileTrigger:
                            info.Type = RealmsInfoType.Secret;
                            info.Notes = $"Tile Trigger - {mob.Data[3]},{mob.Data[2]}";
                            add = true;

                            map.Info.MobInfo.Add(new RealmsInfo
                            {
                                MobGen = true,
                                X = mob.Data[3],
                                Y = mob.Data[2],
                                Type = RealmsInfoType.Secret,
                                Notes = $"Triggered - {mob.X},{mob.Y}"
                            });
                            break;

                        case RealmsMobType.Trap:
                            info.Type = RealmsInfoType.Trap;
                            info.Notes = $"Trap ({ mob.Data[0] }) - { RealmsTrap.GetTrap(rData.Traps, mob.Data[3]).Name }";
                            add = true;
                            break;

                        case RealmsMobType.PitTrap:
                            info.Type = RealmsInfoType.PitTrap;
                            info.Notes = "";
                            info.Mapset = mob.Data[0];
                            info.MapIndex = mob.Data[1];
                            info.MapX = mob.Data[3];
                            info.MapY = mob.Data[2];
                            add = true;
                            break;
                    }

                    if (add)
                    {
                        map.Info.MobInfo.Add(info);
                    }
                }
            }
        }

        public static string[] GetMobTexts(RealmsMob mob, List<RealmsText> rTexts, RealmsData rData)
        {
            var texts = new string[] { "", "", "", "" };
            switch (mob.Type)
            {
                case RealmsMobType.Monster:
                case RealmsMobType.MonsterGuard:
                case RealmsMobType.MonsterAmbush:
                    var mText = rTexts.FirstOrDefault(t => t.Sector.Sector == mob.Data[0] && t.Sector.Offset == mob.Data[1]);
                    texts[1] = mText?.Text;
                    texts[2] = mob.Data[2] == 0 ? "Random #" : $"{ mob.Data[2]} Monster{(mob.Data[2] == 1 ? "" : "s")}";
                    texts[3] = rData.Monsters[mob.Data[3]].Name;
                    break;

                case RealmsMobType.Incidental:
                    var iText = rTexts.FirstOrDefault(t => t.Sector.Sector == mob.Data[0] && t.Sector.Offset == mob.Data[1]);
                    texts[1] = iText?.Text ?? "";
                    break;

                case RealmsMobType.Information:
                case RealmsMobType.NInformation:
                    var nText = rTexts.FirstOrDefault(t => t.Sector.Sector == mob.Data[0] && t.Sector.Offset == mob.Data[1]);
                    var nText2 = rTexts.FirstOrDefault(t => t.Sector.Sector == mob.Data[2] && t.Sector.Offset == mob.Data[3]);
                    texts[1] = nText?.Text ?? "";
                    texts[3] = nText2?.Text ?? "";
                    break;

                case RealmsMobType.ExitToLocal:
                    var eText = rTexts.FirstOrDefault(t => t.Sector.Sector == mob.Data[0] && t.Sector.Offset == mob.Data[1]);
                    texts[1] = eText?.Text ?? "";
                    texts[2] = $"Y - {mob.Data[2]}";
                    texts[3] = $"X - {mob.Data[3]}";
                    break;
            }

            return texts;
        }

        public static string[] GetMobTransactions(RealmsMob mob, RealmsMapset mapset)
        {
            var texts = new string[] { "", "", "" };
            switch (mob.Type)
            {
                case RealmsMobType.Transaction:
                case RealmsMobType.NTransaction:
                    var sector = RealmsSector.CalcSector(mob.Data[2], mob.Data[3]);
                    var offset = mob.Data[1];
                    texts[0] = $"{sector} {offset}";
                    texts[1] = (RealmsSector.CalcDataOffset(sector, offset) + OffsetMobs).ToString();
                    texts[2] = RealmsTransaction.GetDisassembly(sector, offset, mapset);
                    break;
            }
            return texts;
        }

        public static string GetVendorNotes(RealmsTransaction trans)
        {
            var vOptions = new List<string> { "Rest", "Drink" };

            var title = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Title);
            var buy = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Buy);
            var cure = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Cure);
            var gamble = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Gamble);
            var heal = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Heal);
            var ident = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Reveal);
            var sell = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Sell);
            var options = trans.Instructions.Where(o => o.Type == RealmsInstType.Option).ToList();
            var trains = trans.Instructions.Where(i => i.Type == RealmsInstType.Train).ToList();

            var notes = "";
            var oNotes = "";
            foreach (var option in options)
            {
                foreach (var text in option.Texts)
                {
                    if ((text.Contains("Drink") && title != null) || text.Contains("Rest"))
                    {
                        oNotes += $"{text.Substring(1)}\r\n";
                    }
                }
            }

            if (buy != null || cure != null || gamble != null || 
                heal != null || ident != null || sell != null || 
                trains.Count > 0 || oNotes.Length > 0)
            {
                notes = $"{ (title != null ? $"{title.Texts[0]}\r\n\r\n" : "NPC\r\n\r\n")}";
                notes += $"{oNotes}";
                notes += $"{(cure != null ? $"-Cure {cure.Texts[0]}\r\n" : "")}";
                notes += $"{(gamble != null ? $"-Gamble {gamble.Texts[0]}\r\n" : "")}";
                notes += $"{(heal != null ? $"-Heal {heal.Texts[0]}\r\n" : "")}";
                notes += $"{(ident != null ? $"-Identify {ident.Texts[0]}\r\n" : "")}";
                notes += $"{(buy != null ? $"-Buy\r\n  {string.Join("\r\n  ", buy.Texts)}\r\n" : "")}";
                notes += $"{(sell != null ? $"-Sell\r\n  {string.Join(", ", sell.Texts)}\r\n" : "")}";
                notes += $"{(trains.Count > 0 ? $"-Train\r\n  {string.Join("\r\n  ", trains.Select(t => t.Texts[0]).ToList())}\r\n" : "")}";
            }

            return notes;
        }

        public static void ReadMapMobs(RealmsMapset mapset, byte[] data, Action<string> status)
        {
            var offset = OffsetMobs;
            foreach(var map in mapset.Maps)
            {
                if (map.Type != RealmsMapType.Travel)
                {
                    status($"Loading Mob Information: Set{map.Set}-Map{map.Index}...");
                    map.Mobs = ReadRealmsMobs(data, ref offset);
                }
            }
        }

        private static List<RealmsMob> ReadMobs(byte[] data, ref int offset)
        {
            var mobs = new List<RealmsMob>();

            var header = data.Skip(offset).Take(SizeHeader).ToArray();
            offset += SizeHeader;
            for (var m = 0; m < header[1]; m++)
            {
                mobs.Add(RealmsMob.ReadMob(data, ref offset));
            }
            return mobs;
        }

        private static RealmsMobs ReadRealmsMobs(byte[] data, ref int offset)
        {
            var tOffset = offset;
            return new RealmsMobs
            {
                Mobs = ReadMobs(data, ref offset),
                Texts = RealmsText.ReadTexts(data, tOffset, ref offset, ByteBoundry, SizeHeader)
            };
        }
    }
}
