using System.Drawing;

namespace Realms
{
    public class RealmsColor
    {
        public Color Back { get; set; }
        public Color Fore { get; set; }

        public static RealmsColor ToRealmsColor(byte c)
        {
            return new RealmsColor
            {
                Back = ToColor((byte)((c & 0x0F))),
                Fore = ToColor((byte)((c & 0xF0) >> 4))
            };
        }

        public static Color ToColor(byte c)
        {
            switch (c)
            {
                case 0:
                    return Color.Transparent;
                case 1:
                    return Color.FromArgb(0x00, 0x00, 0x00); // Black;
                case 2:
                    return Color.FromArgb(0x21, 0xc8, 0x42); // Green;
                case 3:
                    return Color.FromArgb(0x5e, 0xdc, 0x78); // LightGreen;
                case 4:
                    return Color.FromArgb(0x54, 0x55, 0xed); // Blue;
                case 5:
                    return Color.FromArgb(0x7d, 0x76, 0xfc); // LightBlue;
                case 6:
                    return Color.FromArgb(0xd4, 0x52, 0x4d); // DarkRed;
                case 7:
                    return Color.FromArgb(0x42, 0xeb, 0xf5); // Cyan;
                case 8:
                    return Color.FromArgb(0xfc, 0x55, 0x54); // Red;
                case 9:
                    return Color.FromArgb(0xff, 0x79, 0x78); // LightRed;
                case 10:
                    return Color.FromArgb(0xd4, 0xc1, 0x54); // DarkYellow;
                case 11:
                    return Color.FromArgb(0xe6, 0xce, 0x80); // Yellow;
                case 12:
                    return Color.FromArgb(0x21, 0xb0, 0x3b); // DarkGreen;
                case 13:
                    return Color.FromArgb(0xc9, 0x5b, 0xba); // Magenta;
                case 14:
                    return Color.FromArgb(0xcc, 0xcc, 0xcc); // Gray;
                case 15:
                    return Color.FromArgb(0xff, 0xff, 0xff); // White;
                default:
                    return Color.HotPink;
            }
        }
    }
}
