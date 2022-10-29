namespace Realms
{
    public class RealmsSector
    {
        public const int Size = 256;

        public int Sector { get; set; }
        public int Offset { get; set; }

        public static int CalcDataOffset(int sector, int offset)
        {
            return (sector * Size) + offset;
        }

        public static int CalcSector(byte byte1, byte byte2)
        {
            return RealmsData.ConvertInt(byte1, byte2) & 1023;
        }

        public static RealmsSector GetSector(int offset)
        {
            return new RealmsSector
            {
                Sector = offset / Size,
                Offset = offset % Size
            };
        }

        public static int PadBoundry(int offset, int boundry)
        {
            var bytes = offset % boundry;
            return bytes == 0 ? 0 : boundry - bytes;
        }
    }
}
