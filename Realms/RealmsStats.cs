namespace Realms
{
    public class RealmsStats
    {
        public const int OffsetStats = 192;
        public const int SizeStats = 64;

        public int Level { get; set; }
        public int Class { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Cunning { get; set; }
        public int Reason { get; set; }
        public int ExpCurrent { get; set; }
        public int ExpNext { get; set; }
        public int ExpSkill { get; set; }
        public int Melee { get; set; }
        public int Ranged { get; set; }
        public int Sorcery { get; set; }
        public int Defense { get; set; }
        public int Resist { get; set; }
        public int Lore { get; set; }
        public int Locks { get; set; }
        public int Traps { get; set; }
        public int Gamble { get; set; }
        public int Critical { get; set; }
        public int Actions { get; set; }
        public int Moves { get; set; }
        public int ARed { get; set; }
        public int AOrange { get; set; }
        public int AYellow { get; set; }
        public int AGreen { get; set; }
        public int ABlue { get; set; }
        public int AIndigo { get; set; }
        public int AViolet { get; set; }

        public static RealmsStats LoadStats(byte[] data, int index)
        {
            var offStats = OffsetStats + (index * SizeStats);
            return new RealmsStats
            {
                Level = data[offStats + 0],
                Class = data[offStats + 1],
                ExpCurrent = RealmsData.ConvertInt(data[offStats + 2], data[offStats + 3]),
                ExpNext = RealmsData.ConvertInt(data[offStats + 4], data[offStats + 5]),
                Strength = data[offStats + 6],
                Agility = data[offStats + 7],
                Cunning = data[offStats + 8],
                Reason = data[offStats + 9],
                Melee = data[offStats + 10],
                Ranged = data[offStats + 11],
                Sorcery = data[offStats + 12],
                Defense = data[offStats + 13],
                Resist = data[offStats + 14],
                Lore = data[offStats + 15],
                Locks = data[offStats + 16],
                Traps = data[offStats + 17],
                Gamble = data[offStats + 18],
                Critical = data[offStats + 19],
                Actions = data[offStats + 20],
                Moves = data[offStats + 21],
                ARed = data[offStats + 22],
                AOrange = data[offStats + 23],
                AYellow = data[offStats + 24],
                AGreen = data[offStats + 25],
                ABlue = data[offStats + 26],
                AIndigo = data[offStats + 27],
                AViolet = data[offStats + 28],
                ExpSkill = data[offStats + 29]
            };
        }

        public static void UpdateStats(byte[] data, int index, RealmsStats stats)
        {
            var offStats = OffsetStats + (index * SizeStats);
            RealmsData.UpdateData(data, offStats + 0, stats.Level);
            RealmsData.UpdateData(data, offStats + 1, stats.Class);
            RealmsData.UpdateData(data, offStats + 2, stats.ExpCurrent, 2);
            RealmsData.UpdateData(data, offStats + 4, stats.ExpNext, 2);
            RealmsData.UpdateData(data, offStats + 6, stats.Strength);
            RealmsData.UpdateData(data, offStats + 7, stats.Agility);
            RealmsData.UpdateData(data, offStats + 8, stats.Cunning);
            RealmsData.UpdateData(data, offStats + 9, stats.Reason);
            RealmsData.UpdateData(data, offStats + 10, stats.Melee);
            RealmsData.UpdateData(data, offStats + 11, stats.Ranged);
            RealmsData.UpdateData(data, offStats + 12, stats.Sorcery);
            RealmsData.UpdateData(data, offStats + 13, stats.Defense);
            RealmsData.UpdateData(data, offStats + 14, stats.Resist);
            RealmsData.UpdateData(data, offStats + 15, stats.Lore);
            RealmsData.UpdateData(data, offStats + 16, stats.Locks);
            RealmsData.UpdateData(data, offStats + 17, stats.Traps);
            RealmsData.UpdateData(data, offStats + 18, stats.Gamble);
            RealmsData.UpdateData(data, offStats + 19, stats.Critical);
            RealmsData.UpdateData(data, offStats + 22, stats.ARed);
            RealmsData.UpdateData(data, offStats + 23, stats.AOrange);
            RealmsData.UpdateData(data, offStats + 24, stats.AYellow);
            RealmsData.UpdateData(data, offStats + 25, stats.AGreen);
            RealmsData.UpdateData(data, offStats + 26, stats.ABlue);
            RealmsData.UpdateData(data, offStats + 27, stats.AIndigo);
            RealmsData.UpdateData(data, offStats + 28, stats.AViolet);
            RealmsData.UpdateData(data, offStats + 29, stats.ExpSkill);
        }
    }
}
