using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Realms
{
    public enum RealmsEdgeDir
    {
        [Description("South")]
        South,
        [Description("West")]
        West,
        [Description("North")]
        North,
        [Description("East")]
        East
    }

    public class RealmsEdge
    {
        public const int OffsetEdge = 32;
        public const int SizeEdge = 4;

        public RealmsEdgeDir Dir { get; set; }
        public int Set { get; set; }
        public int Index { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public static RealmsEdge GetEdge(RealmsMap map, int x, int y)
        {
            var dir = -1;
            if (y == 0 && x > 0 && x < (map.Width - 1))
            {
                dir = (int)RealmsEdgeDir.North;
            }
            if (y == (map.Height - 1) && x > 0 && x < (map.Width - 1))
            {
                dir = (int)RealmsEdgeDir.South;
            }
            if (x == 0 && y > 0 && y < (map.Height - 1))
            {
                dir = (int)RealmsEdgeDir.West;
            }
            if (x == (map.Width - 1) && y > 0 && y < (map.Height - 1))
            {
                dir = (int)RealmsEdgeDir.East;
            }
            return map.Edges.FirstOrDefault(e => (int)e.Dir == dir);
        }

        public static List<RealmsEdge> LoadEdges(RealmsMap map, byte[] data)
        {
            var edges = new List<RealmsEdge>();
            var offset = OffsetEdge;
            for (var d = 0; d < 4; d++)
            {
                var cur = data.Skip(offset).Take(SizeEdge).ToArray();
                if (cur[0] != 0 || cur[1] != 0 || cur[2] != 0 || cur[3] != 0)
                {
                    edges.Add(new RealmsEdge
                    {
                        Dir = (RealmsEdgeDir)d,
                        Set = cur[0],
                        Index = cur[1],
                        X = cur[3],
                        Y = cur[2]
                    });
                }
                offset += SizeEdge;
            }

            return edges;
        }
    }
}
