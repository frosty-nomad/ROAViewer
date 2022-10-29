using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Realms
{
    public class RealmsChar
    {
        public const int Bytes = 8;
        public const int Height = 8;
        public const int Width = 8;

        public const int OffsetChars = 73856;

        public const int ColsCharset = 16;
        public const int CountCharset = 128;
        public const int CountCharsets = 16;
        public const int SizeCharset = 1024;

        public Bitmap Bitmap { get; set; }
        public List<RealmsColor> Colors { get; set; }
        public List<string> Pixels { get; set; }

        public static int CalcCharsetIndex(int x, int y, RealmsData rData)
        {
            var nX = x / ((rData.Options.PixelSize * Width) + 1);
            var nY = y / ((rData.Options.PixelSize * Height) + 1);
            return (nY * ColsCharset) + nX;
        }

        public static Bitmap CharBitmap(List<string> pixels, List<RealmsColor> colors, int pixelSize)
        {
            var bitmap = new Bitmap(Width * pixelSize, Height * pixelSize);
            var graphics = Graphics.FromImage(bitmap);

            var row = 0;
            foreach(var pixel in pixels)
            {
                var fColor = colors.Count > row ? colors[row].Fore : Color.HotPink;
                var bColor = colors.Count > row ? colors[row].Back : Color.HotPink;
                var col = 0;
                foreach(var p in pixel)
                {
                    graphics.FillRectangle(new SolidBrush(p == '1' ? fColor : bColor), col * pixelSize, row * pixelSize, pixelSize, pixelSize);
                    col++;
                }
                row++;
            }

            return bitmap;
        }

        public static Bitmap CharsetBitmap(List<RealmsChar> chars, int set, RealmsData rData, bool showGrid)
        {
            var cols = ColsCharset;
            var rows = CountCharset / cols;
            var cSize = (rData.Options.PixelSize * 8) + (showGrid ? 1 : 0); // Character size
            var bitmap = new Bitmap(cols * cSize, rows * cSize);

            using (var g = Graphics.FromImage(bitmap))
            {
                var index = set * CountCharset;
                for (var r = 0; r < rows; r++)
                {
                    for (var c = 0; c < cols; c++)
                    {
                        g.DrawImage(chars[index++].Bitmap, c * cSize, r * cSize);
                    }
                }
            }

            return bitmap;
        }

        public static int CalcOffset(int set, int offset)
        {
            return ((set + (offset < 128 ? 1 : 0)) * CountCharset) - CountCharset + offset;
        }

        public static List<RealmsChar> LoadChars(string dir, RealmsOptions options)
        {
            var data = File.ReadAllBytes($"{dir}\\PRG");

            var chars = new List<RealmsChar>();
            var curOffset = OffsetChars;
            for (var i = 0; i < CountCharsets; i++)
            {
                for (var c = 0; c < CountCharset; c++)
                {
                    var pixels = data.Skip(curOffset + (c * Bytes)).Take(Bytes).ToArray();
                    var colors = data.Skip((curOffset + SizeCharset) + (c * Bytes)).Take(Bytes).ToArray();
                    chars.Add(ToChar(pixels, colors, options.PixelSize));
                }
                curOffset += SizeCharset * 2;
            }

            return chars;
        }

        public static RealmsChar ToChar(byte[] pixels, byte[] colors, int pixelSize)
        {
            var nPixels = pixels.Select(p => Convert.ToString(p, 2).PadLeft(8, '0')).ToList();
            var nColors = colors.Select(c => RealmsColor.ToRealmsColor(c)).ToList();
            return new RealmsChar
            {
                Pixels = nPixels,
                Colors = nColors,
                Bitmap = CharBitmap(nPixels, nColors, pixelSize)
            };
        }

        public static int ToCharset(int metaValue)
        {
            switch (metaValue)
            {
                case 0:
                    return 3;
                case 4:
                    return 4;
                case 8:
                    return 5;
                case 12:
                    return 6;
                case 16:
                    return 7;
                case 20:
                    return 8;
                case 24:
                    return 9;
                case 28:
                    return 10;
                case 32:
                    return 11;
                default:
                    return 0;
            }
        }
    }
}
