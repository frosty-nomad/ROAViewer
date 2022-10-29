using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Realms
{
    public enum RealmsMapType
    {
        Indoor = 0,
        Outdoor = 1,
        Travel = 255
    }

    [Serializable]
    public class RealmsMap
    {
        public RealmsMapType Type { get; set; }
        public int Charset { get; set; }
        public List<RealmsEdge> Edges { get; set; }
        public int Height { get; set; }
        public int Index { get; set; }
        public RealmsMapInfo Info { get; set; }
        public bool LDiag { get; set; }
        public byte[] MapData { get; set; }
        public RealmsMobs Mobs { get; set; } = new RealmsMobs();
        public bool RDiag { get; set; }
        public int Set { get; set; }
        public int Width { get; set; }
        public bool Wrap { get; set; }

        public RealmsMap()
        {
        }

        public RealmsMap(RealmsMap map)
        {
            Type = map.Type;
            Charset = map.Charset;
            Edges = map.Edges;
            Height = map.Height;
            Index = map.Index;
            Info = new RealmsMapInfo();
            LDiag = map.LDiag;
            MapData = map.MapData;
            RDiag = map.RDiag;
            Set = map.Set;
            Width = map.Width;
            Wrap = map.Wrap;
        }

        public static Bitmap BuildBitmap(RealmsMap map, RealmsData rData)
        {
            CalcBitmap(map, rData.Options, out var width, out var height);
            var bitmap = new Bitmap(width, height);

            using (var g = Graphics.FromImage(bitmap))
            {
                for (var y = 0; y < map.Height; y++)
                {
                    for (var x = 0; x < map.Width; x++)
                    {
                        DrawTile(map, x, y, rData, g);
                    }
                }
            }

            return bitmap;
        }

        public static int CalcBitmapX(RealmsMap map, int x, int y, int charSize)
        {
            var calcX = x;
            if (map.RDiag)
            {
                calcX = (map.Height - y - 1) + x;
            }
            if (map.LDiag)
            {
                calcX = y + x;
            }
            return calcX * charSize;
        }

        public static int CalcBitmap(RealmsMap map, RealmsOptions options, out int width, out int height)
        {
            var tSize = CalcTileSize(options);
            var dWidth = map.Width + (map.RDiag || map.LDiag ? map.Height - 1 : 0); 
            width = dWidth * tSize;
            height = map.Height * tSize;
            return width * height;
        }

        public static int CalcTileSize(RealmsOptions options)
        {
            return (options.PixelSize * RealmsChar.Width) + (options.ShowGrid ? 1 : 0);
        }

        public void Coords(int picX, int picY, out int x, out int y, RealmsOptions options)
        {
            var tSize = CalcTileSize(options);
            y = (picY / tSize);
            x = CalcMapX(this, picX / tSize, y);
        }

        public static string DefaultMapName(int set, int index)
        {
            return $"Set{set}-Map{index}";
        }

        public static void DrawEdge(RealmsMap map, RealmsEdge edge, RealmsData rData, Bitmap bitmap, bool show = true)
        {
            var size = CalcTileSize(rData.Options);
            var horz = new List<RealmsEdgeDir> { RealmsEdgeDir.North, RealmsEdgeDir.South }.Contains(edge.Dir);
            var vert = new List<RealmsEdgeDir> { RealmsEdgeDir.East, RealmsEdgeDir.West }.Contains(edge.Dir);

            if (horz)
            {
                using (var graph = Graphics.FromImage(bitmap))
                {
                    var y = edge.Dir == RealmsEdgeDir.North ? 0 : map.Height - 1;
                    for (var x = 1; x < map.Width - 1; x++)
                    {
                        if (show)
                        {
                            HighlightTile(map, x, y, size, graph, rData.Options.GetInfoColor(RealmsInfoType.Map), 128);
                        }
                        else
                        {
                            DrawTile(map, x, y, rData, graph);
                        }
                    }
                }
            }

            if (vert)
            {
                using (var graph = Graphics.FromImage(bitmap))
                {
                    var x = edge.Dir == RealmsEdgeDir.West ? 0 : map.Width - 1;
                    for (var y = 1; y < map.Height - 1; y++)
                    {
                        if (show)
                        {
                            HighlightTile(map, x, y, size, graph, rData.Options.GetInfoColor(RealmsInfoType.Map), 128);
                        }
                        else
                        {
                            DrawTile(map, x, y, rData, graph);
                        }
                    }
                }
            }
        }

        public static void DrawTile(RealmsMap map, int x, int y, RealmsData rData, Graphics graph)
        {
            var tSize = CalcTileSize(rData.Options);
            var info = RealmsMapInfo.GetInfo(x, y, map.Info, rData.Options);
            var mob = map.Mobs.Mobs.FirstOrDefault(m => m.X == x && m.Y == y && RealmsMob.IsMapMob(m));

            if (mob != null)
            {
                graph.DrawImage(RealmsMob.GetChar(mob, map.Charset, rData).Bitmap, CalcBitmapX(map, mob.X, mob.Y, tSize), mob.Y * tSize);
                if (info == null && rData.Options.Shading > 0)
                {
                    HighlightTile(map, mob.X, mob.Y, tSize, graph, Color.Black, rData.Options.Shading);
                }
            }
            else
            {
                graph.DrawImage(rData.Chars[RealmsChar.CalcOffset(map.Charset, CalcOffset(map, x, y))].Bitmap, CalcBitmapX(map, x, y, tSize), y * tSize);
                if (info == null && rData.Options.Shading > 0)
                {
                    HighlightTile(map, x, y, tSize, graph, Color.Black, rData.Options.Shading);
                }
            }

            if (info != null)
            {
                var pen = new Pen(rData.Options.GetInfoColor(info.Type), 2);
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                graph.DrawRectangle(pen, CalcBitmapX(map, info.X, info.Y, tSize), info.Y * tSize, tSize, tSize);
            }
        }

        public RealmsInfo GetEditInfo(int x, int y)
        {
            var curInfo = Info.Info.FirstOrDefault(i => i.X == x && i.Y == y);
            if (curInfo != null)
            {
                if (curInfo.MobGen)
                {
                    var newInfo = curInfo.Copy();
                    Info.Info.Remove(curInfo);
                    Info.Info.Add(newInfo);
                    return newInfo;
                }
                return curInfo;
            }
            else
            {
                var mobInfo = Info.MobInfo.FirstOrDefault(i => i.X == x && i.Y == y);
                var newInfo = new RealmsInfo
                {
                    Type = mobInfo != null ? mobInfo.Type : RealmsInfoType.Info,
                    X = x,
                    Y = y,
                    Mapset = mobInfo != null ? mobInfo.Mapset : -1,
                    MapIndex = mobInfo != null ? mobInfo.MapIndex : -1,
                    MapX = mobInfo != null ? mobInfo.MapX : -1,
                    MapY = mobInfo != null ? mobInfo.MapY : -1,
                    Notes = mobInfo != null ? mobInfo.Notes : ""
                };
                Info.Info.Add(newInfo);
                return newInfo;
            }
        }

        private static int CalcMapX(RealmsMap map, int x, int y)
        {
            var newX = x;
            var min = 0;
            var max = map.Width - 1;
            if (map.RDiag)
            {
                min = map.Height - 1 - y;
                max = min + (map.Width - 1);
                newX = x - min;
            }

            if (map.LDiag)
            {
                min = y;
                max = min + (map.Width - 1);
                newX = x - y;
            }

            return x >= min && x <= max ? newX : -1;
        }

        private static byte CalcOffset(RealmsMap map, int x, int y)
        {
            var calcX = x;
            var calcY = y;

            if (map.Wrap)
            {
                calcX = (x == 0 ? map.Width : x) - 1;
                if (x == 0)
                {
                    calcY = (y == 0 ? map.Height : y) - 1;
                }
            }

            calcX = calcX > (map.Width - 1) ? map.Width - 1 : calcX;
            calcY = calcY > (map.Height - 1) ? map.Height - 1 : calcY;

            return map.MapData[(calcY * map.Width) + calcX];
        }

        private static void HighlightTile(RealmsMap map, int x, int y, int size, Graphics graph, Color color, int alpha)
        {
            graph.FillRectangle(new SolidBrush(Color.FromArgb(alpha, color)), CalcBitmapX(map, x, y, size), y * size, size, size);
        }
    }
}
