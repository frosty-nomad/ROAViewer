using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Realms
{
    public enum RealmsInstType
    {
        [Description("!END")]
        End,
        [Description("!BRANCH")]
        Branch,
        [Description("!SCREEN")]
        Screen,
        [Description("!TITLE")]
        Title,
        [Description("!SOUND")]
        Sound,
        [Description("?LOCAL_FLAG")]
        CLocalFlag,
        [Description("?QUEST_FLAG")]
        CQuestFlag,
        [Description("?QUEST_ITEM")]
        CQuestItem,
        [Description("?ITEM")]
        CItem,
        [Description("?PARTY")]
        CParty,
        [Description("?SKILL")]
        CSkill,
        [Description("?LOCAL_MOB")]
        CLocalMob,
        [Description("?EXT_MOB")]
        CExtMob,
        [Description("!MSG")]
        Msg,
        [Description("!RMSG")]
        RMsg,
        [Description("!OPTION")]
        Option,
        [Description("!INPUT")]
        Input,
        [Description("!LOCAL_FLAG")]
        SLocalFlag,
        [Description("!LOCAL_FLAG")]
        RLocalFlag,
        [Description("!QUEST_FLAG")]
        SQuestFlag,
        [Description("!QUEST_FLAG")]
        RQuestFlag,
        [Description("!QUEST_ITEM")]
        SQuestItem,
        [Description("!QUEST_ITEM")]
        RQuestItem,
        [Description("!TRAIN")]
        Train,
        [Description("!EFFECT")]
        Effect,
        [Description("!ITEM")]
        Item,
        [Description("!MONEY")]
        Money,
        [Description("!FOOD")]
        Food,
        [Description("!BOAT")]
        Boat,
        [Description("!LOCAL_MOB")]
        LocalMob,
        [Description("!EXT_MOB")]
        ExtMob,
        [Description("!CLEAR_MOB")]
        ClearMob,
        [Description("!ENCOUNTER")]
        Encounter,
        [Description("!LOCATE")]
        Locate,
        [Description("!JOIN")]
        Join,
        [Description("!HEAL")]
        Heal,
        [Description("!CURE")]
        Cure,
        [Description("!REVEAL")]
        Reveal,
        [Description("!REST")]
        Rest,
        [Description("!BUY")]
        Buy,
        [Description("!SELL")]
        Sell,
        [Description("!SAIL")]
        Sail,
        [Description("!GAMBLE")]
        Gamble,
        [Description("!LIGHT")]
        Light,
        [Description("!RETURN")]
        Return,
        [Description("?BACKPACK")]
        Backpack,
        [Description("!VAULT")]
        Vault
    }

    public class RealmsInstruction
    {
        public RealmsInstType Type { get; set; }
        public int Line { get; set; }
        public List<int> Branches { get; set; } = new List<int>();
        public List<byte> Data { get; set; } = new List<byte>();
        public int Length { get { return Data.Count + SubData.Count + 1; } }
        public int Lines { get { return GetLines(this); } }
        public List<byte> SubData { get; set; } = new List<byte>();
        public List<string> Texts { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"{Line:000} {Type.GetDescription()}";
        }

        public static RealmsInstruction GetInstruction(byte[] data, int offset, int line, RealmsData rData)
        {
            var tInst = new RealmsInstruction
            {
                Type = (RealmsInstType)data[offset],
                Line = line
            };

            var tData = data.Skip(offset + 1).ToArray();
            var tText = "";
            switch (tInst.Type)
            {
                case RealmsInstType.End:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.Texts.Add(tInst.Data[0] == 1 ? "NoWait" : "");
                    break;

                case RealmsInstType.Branch:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.Branches.Add(tInst.Data[0]);
                    break;

                case RealmsInstType.Screen:
                    tInst.Data = tData.Take(1).ToList();
                    switch (tInst.Data[0])
                    {
                        case 0:
                            tText = "Standard";
                            break;
                        case 1:
                            tText = "Store";
                            break;
                        case 2:
                            tText = "Book";
                            break;
                        default:
                            tText = $"{tInst.Data[0]}";
                            break;
                    }
                    tInst.Texts.Add(tText);
                    break;

                case RealmsInstType.Title:
                    tInst.Data = tData.Take(3).ToList();
                    tInst.Texts.Add($"{GetMessage(data, tInst.Data[1], tInst.Data[2])}");
                    break;

                case RealmsInstType.Sound:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.Texts.Add($"S:{tInst.Data[0]}");
                    break;

                case RealmsInstType.CLocalFlag:
                case RealmsInstType.CQuestFlag:
                case RealmsInstType.CQuestItem:
                    tInst.Data = tData.Take(3).ToList();
                    tInst.Texts.Add($"{tInst.Data[0]}={(tInst.Data[1] == 128 ? "1" : "0")}");
                    tInst.Branches.Add(tInst.Data[2]);
                    break;

                case RealmsInstType.CItem:
                    tInst.Data = tData.Take(5).ToList();
                    tInst.Texts.Add($"{RealmsData.ConvertInt(tInst.Data[1], tInst.Data[2])}");
                    tInst.Branches.Add(RealmsData.ConvertInt(tInst.Data[3], tInst.Data[4]));
                    break;

                case RealmsInstType.CParty:
                    tInst.Data = tData.Take(3).ToList();
                    tInst.Texts.Add($"P:{tInst.Data[0]}");
                    tInst.Branches.Add(RealmsData.ConvertInt(tInst.Data[1], tInst.Data[2]));
                    break;

                case RealmsInstType.CSkill:
                    tInst.Data = tData.Take(5).ToList();
                    tInst.Texts.Add($"{tInst.Data[0]},{tInst.Data[1]}");
                    tInst.Branches.Add(RealmsData.ConvertInt(tInst.Data[3], tInst.Data[4]));
                    break;

                case RealmsInstType.CLocalMob:
                    tInst.Data = tData.Take(5).ToList();
                    tInst.Texts.Add($"{tInst.Data[0]},{tInst.Data[1]},{tInst.Data[2]}");
                    tInst.Branches.Add(RealmsData.ConvertInt(tInst.Data[3], tInst.Data[4]));
                    break;

                case RealmsInstType.CExtMob:
                    tInst.Data = tData.Take(7).ToList();
                    tInst.Texts.Add($"{rData.Monsters[RealmsData.ConvertInt(tInst.Data[1], tInst.Data[2])].Name},{tInst.Data[3]}");
                    tInst.Branches.Add(RealmsData.ConvertInt(tInst.Data[5], tInst.Data[6]));
                    break;

                case RealmsInstType.Msg:
                case RealmsInstType.RMsg:
                    tInst.Data = tData.Take((tData[0] * 2) + 1).ToList();
                    for (var m = 0; m < tInst.Data[0]; m++)
                    {
                        var s = (m * 2) + 1;
                        tInst.Texts.Add($"{GetMessage(data, tInst.Data[s], tInst.Data[s + 1])}");
                    }
                    break;

                case RealmsInstType.Option:
                    tInst.Data = tData.Take((tData[0] * 4) + 1).ToList();
                    for (var m = 0; m < tInst.Data[0]; m++)
                    {
                        var s = (m * 4) + 1;
                        tInst.Texts.Add($"{m + 1}-{GetMessage(data, tInst.Data[s], tInst.Data[s + 1])}");
                        tInst.Branches.Add(tInst.Data[s + 3]);
                    }
                    break;

                case RealmsInstType.Input:
                    tInst.Data = tData.Take(1).ToList();
                    switch (tInst.Data[0])
                    {
                        case 0:
                            tText = "Any Key";
                            break;
                        case 1:
                            tText = "Select Option";
                            break;
                        case 2:
                            tText = "Select Player";
                            break;
                        default:
                            tText = $"{tInst.Data[0]}";
                            break;
                    }
                    tInst.Texts.Add(tText);
                    break;

                case RealmsInstType.SLocalFlag:
                case RealmsInstType.RLocalFlag:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.Texts.Add($"{tInst.Data[0]}={(tInst.Type == RealmsInstType.SLocalFlag ? "1" : "0")}");
                    break;

                case RealmsInstType.SQuestFlag:
                case RealmsInstType.RQuestFlag:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.Texts.Add($"{tInst.Data[0]}={(tInst.Type == RealmsInstType.SQuestFlag ? "1" : "0")}");
                    break;

                case RealmsInstType.SQuestItem:
                case RealmsInstType.RQuestItem:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.Texts.Add($"{tInst.Data[0]}={(tInst.Type == RealmsInstType.SQuestItem ? "1" : "0")}");
                    break;

                case RealmsInstType.Train:
                    tInst.Data = tData.Take(5).ToList();
                    tInst.Texts.Add($"{((RealmsSkillType)tInst.Data[0]).GetDescription()} Max:{tInst.Data[2]} {RealmsData.ConvertInt(tInst.Data[3], tInst.Data[4])}");
                    break;

                case RealmsInstType.Effect:
                    tInst.Data = tData.Take(5).ToList();
                    switch (tInst.Data[0])
                    {
                        case 255:
                            tText = "Party";
                            break;
                        case 0:
                            tText = "Select";
                            break;
                        case 1:
                            tText = "All";
                            break;
                    }
                    tText += $",{RealmsItem.EffectType(tInst.Data[0])},{tInst.Data[2]},{tInst.Data[3]}";
                    tInst.Texts.Add(tText);
                    break;

                case RealmsInstType.Item:
                    tInst.Data = tData.Take(3).ToList();
                    var bItem = RealmsItem.GetItem(tInst.Data[1], tInst.Data[2], rData.Items);
                    tInst.Texts.Add($"{(tInst.Data[0] == 0 ? "Give" : "Remove")},{bItem.Name}");
                    break;

                case RealmsInstType.Money:
                case RealmsInstType.Food:
                    tInst.Data = tData.Take(3).ToList();
                    switch (tInst.Data[0])
                    {
                        case 0:
                            tText = "Give";
                            break;
                        case 2:
                            tText = "Take";
                            break;
                        default:
                            tText = "TakeEach";
                            break;
                    }
                    tText += $",{RealmsData.ConvertInt(tInst.Data[1], tInst.Data[2])}";
                    tInst.Texts.Add(tText);
                    break;

                case RealmsInstType.Boat:
                    tInst.Data = tData.Take(3).ToList();
                    tInst.Texts.Add($"X:{tInst.Data[2]} Y:{tInst.Data[1]}");
                    break;

                case RealmsInstType.LocalMob:
                    tInst.Data = tData.Take(3 + (tData[0] == 255 ? 2 : 0)).ToList();
                    tInst.Texts.Add($"{(tInst.Data[0] == 255 ? $"{tInst.Data[1]}-{tInst.Data[2]}" : tInst.Data[0] == 128 ? "Self" : tInst.Data[0].ToString())}");
                    break;

                case RealmsInstType.ExtMob:
                    tInst.Data = tData.Take(5).ToList();
                    tInst.Texts.Add($"{tInst.Data[0]} {rData.Monsters[tInst.Data[2]].Name}, {tInst.Data[3]}");
                    break;

                case RealmsInstType.ClearMob:
                    tInst.Data = tData.Take(tData[0] == 255 ? 3 : 1).ToList();
                    tInst.Texts.Add($"{(tInst.Data[0] == 255 ? $"{tInst.Data[1]}-{tInst.Data[2]}" : tInst.Data[0] == 128 ? "Self" : tInst.Data[0].ToString())}");
                    break;

                case RealmsInstType.Encounter:
                    tInst.Data = tData.Take((tData[1] * 2) + 9).ToList();
                    tText = $"{((tInst.Data[0] & 128) == 128 ? "NoClear" : "Clear")}";
                    if ((tInst.Data[0] & 8) == 8)
                    {
                        tText += $",Ambush";
                    }
                    else
                    {
                        switch (tInst.Data[0] & 7)
                        {
                            case 0:
                                tText += ",Left";
                                break;
                            case 2:
                                tText += ",Right";
                                break;
                            case 4:
                                tText += ",Up";
                                break;
                            case 6:
                                tText += ",Down";
                                break;
                        }
                    }
                    switch (tInst.Data[2])
                    {
                        case 1:
                            tText += $",QuestFlag-{tInst.Data[3]}";
                            break;
                        case 2:
                            tText += $",QuestItem-{rData.Quests[tInst.Data[3]].Name}";
                            break;
                        case 3:
                            tText += ",Mirror";
                            break;
                        default:
                            tText += ",None";
                            break;
                    }
                    tInst.Texts.Add(tText);
                    for (var m = 0; m < tInst.Data[1]; m++)
                    {
                        var i = (m * 2) + 9;
                        tInst.Texts.Add($"{(tInst.Data[i] > 0 ? tInst.Data[i].ToString() : "Rand")}-{rData.Monsters[tInst.Data[i + 1]].Name}");
                    }
                    break;

                case RealmsInstType.Locate:
                    tInst.Data = tData.Take(5).ToList();
                    break;

                case RealmsInstType.Join:
                    tInst.Data = tData.Take(3).ToList();
                    tInst.Texts.Add(((RealmsClassType)tInst.Data[0]).GetDescription());
                    tInst.Branches.Add(tInst.Data[2]);
                    break;

                case RealmsInstType.Heal:
                case RealmsInstType.Cure:
                case RealmsInstType.Reveal:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.Texts.Add($"{tInst.Data[0]}");
                    break;

                case RealmsInstType.Rest:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.Texts.Add((tInst.Data[0] & 128) > 0 ? "Don't Save" : "Save");
                    break;

                case RealmsInstType.Buy:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.SubData = GetSubData(tInst.Type, tData);
                    var bCount = tInst.Data[0];
                    for (var m = 0; m < bCount; m++)
                    {
                        var i = m * 2;
                        var c = (bCount * 2) + i;
                        var cItem = RealmsItem.GetItem(tInst.SubData[i], tInst.SubData[i + 1], rData.Items);
                        tInst.Texts.Add($"{(cItem != null ? cItem.Name : tInst.SubData[i].ToString())}{(RealmsItem.IsAmmo(tInst.SubData[i]) ? $"({tInst.SubData[i + 1]})" : "")} - " +
                                        $"{RealmsData.ConvertInt(tInst.SubData[c], tInst.SubData[c + 1])}");
                    }
                    break;

                case RealmsInstType.Sell:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.SubData = GetSubData(tInst.Type, tData);
                    for (var m = 0; m < tInst.Data[0]; m++)
                    {
                        tInst.Texts.Add($"{(rData.Types.ContainsKey(tInst.SubData[m]) ? rData.Types[tInst.SubData[m]] : tInst.SubData[m].ToString())}");
                    }
                    break;

                case RealmsInstType.Sail:
                    tInst.Data = tData.Take(1).ToList();
                    tInst.SubData = GetSubData(tInst.Type, tData);
                    break;

                case RealmsInstType.Gamble:
                    tInst.SubData = GetSubData(tInst.Type, tData);
                    tText = "";
                    for (var o = 0; o < tInst.SubData[3]; o++)
                    {
                        var i = (o * 4) + (tInst.SubData[4] * 4) + 5;
                        tText += $"{RealmsData.ConvertInt(tInst.SubData[i + 2], tInst.SubData[i + 3])} ";
                    }
                    tInst.Texts.Add(tText);
                    tInst.Texts.Add($"{GetMessage(data, tInst.SubData[1], tInst.SubData[2])}");
                    for (var o = 0; o < tInst.SubData[4]; o++)
                    {
                        var i = (o * 4) + 5;
                        tInst.Texts.Add($"{GetMessage(data, tInst.SubData[i], tInst.SubData[i + 1])} S:{RealmsData.ConvertInt(tInst.SubData[i + 2], tInst.SubData[i + 3])}");
                    }
                    break;

                case RealmsInstType.Light:
                    tInst.Data = tData.Take(1).ToList();
                    break;

                case RealmsInstType.Return:
                    tInst.Data = tData.Take(1).ToList();
                    break;

                case RealmsInstType.Backpack:
                    tInst.Data = tData.Take(3).ToList();
                    break;

                case RealmsInstType.Vault:
                    tInst.Data = tData.Take(1).ToList();
                    break;

                default:
                    throw new System.Exception($"Instruction {tInst.Type} not found");
            }

            return tInst;
        }

        private static int GetLines(RealmsInstruction inst)
        {
            switch (inst.Type)
            {
                case RealmsInstType.End:
                case RealmsInstType.Branch:
                case RealmsInstType.Screen:
                case RealmsInstType.Sound:
                case RealmsInstType.Input:
                case RealmsInstType.RLocalFlag:
                case RealmsInstType.SLocalFlag:
                case RealmsInstType.RQuestFlag:
                case RealmsInstType.SQuestFlag:
                case RealmsInstType.RQuestItem:
                case RealmsInstType.SQuestItem:
                case RealmsInstType.Heal:
                case RealmsInstType.Cure:
                case RealmsInstType.Reveal:
                case RealmsInstType.Rest:
                case RealmsInstType.Light:
                case RealmsInstType.Return:
                case RealmsInstType.Vault:
                    return 1;

                case RealmsInstType.Title:
                case RealmsInstType.CLocalFlag:
                case RealmsInstType.CQuestFlag:
                case RealmsInstType.CQuestItem:
                case RealmsInstType.Item:
                case RealmsInstType.Money:
                case RealmsInstType.Food:
                case RealmsInstType.Boat:
                case RealmsInstType.Join:
                case RealmsInstType.CParty:
                case RealmsInstType.Backpack:
                    return 2;

                case RealmsInstType.CItem:
                case RealmsInstType.CSkill:
                case RealmsInstType.CLocalMob:
                case RealmsInstType.Train:
                case RealmsInstType.Effect:
                case RealmsInstType.ExtMob:
                case RealmsInstType.Locate:
                    return 3;

                case RealmsInstType.CExtMob:
                    return 4;

                case RealmsInstType.Msg:
                case RealmsInstType.RMsg:
                    return inst.Data.Count > 0 ? 1 + inst.Data[0] : 1;

                case RealmsInstType.Option:
                    return inst.Data.Count > 0 ? 1 + (inst.Data[0] * 2) : 1;

                case RealmsInstType.LocalMob:
                    return inst.Data.Count > 0 ? 2 + (inst.Data[0] == 255 ? 1 : 0) : 2;

                case RealmsInstType.ClearMob:
                    return inst.Data.Count > 0 ? 1 + (inst.Data[0] == 255 ? 1 : 0) : 1;

                case RealmsInstType.Encounter:
                    return inst.Data.Count > 1 ? 5 + inst.Data[1] : 1;

                case RealmsInstType.Buy:
                    return inst.Data.Count > 0 ? 1 + (inst.Data[0] * 2) : 1;

                case RealmsInstType.Sell:
                    return inst.Data.Count > 0 ? 1 + ((inst.Data[0] / 2) + ((inst.Data[0] % 2))) : 1;

                case RealmsInstType.Sail:
                    return 5 + ((inst.SubData.Count - 8) / 2);

                case RealmsInstType.Gamble:
                    return inst.SubData.Count > 4 ? 3 + (inst.SubData[3] * 2) + (inst.SubData[4] * 2) : 3;

                default:
                    throw new System.Exception($"Instruction Lines for {inst.Type} not found");
            }
        }

        public static RealmsText GetMessage(byte[] data, int sector, int offset)
        {
            var mOffset = RealmsSector.CalcDataOffset(sector, offset);
            return RealmsText.GetText(data, 0, mOffset);
        }

        public static List<byte> GetSubData(RealmsInstType type, byte[] data)
        {
            switch (type)
            {
                case RealmsInstType.Buy:
                    return data.Skip(1).Take(data[0] * 4).ToList();

                case RealmsInstType.Sell:
                    return data.Skip(1).Take(data[0] + (data[0] % 2 != 0 ? 1 : 0)).ToList();

                case RealmsInstType.Sail:
                    return data.Skip(1).Take(data[0] + 8 + (data[0] % 2 != 0 ? 1 : 0)).ToList();

                case RealmsInstType.Gamble:
                    return data.Take((data[3] * 4) + (data[4] * 4) + 5).ToList();

                default:
                    return null;
            }
        }
    }
}
