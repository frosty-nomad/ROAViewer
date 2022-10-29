using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realms
{
    public enum RealmsSubTransType
    {
        Buy,
        Sell,
        Sail,
        Gamble
    }

    public class RealmsSubTrans
    {
        public RealmsSubTransType Type { get; set; }
        public byte[] Data { get; set; }

        public static RealmsSubTrans GetSubTrans(RealmsInstType type, byte[] data)
        {
            switch (type)
            {
                case RealmsInstType.Buy:
                    return new RealmsSubTrans
                    {
                        Type = RealmsSubTransType.Buy,
                        Data = data.Skip(1).Take(data[0] * 4).ToArray()
                    };
                case RealmsInstType.Sell:
                    return new RealmsSubTrans
                    {
                        Type = RealmsSubTransType.Sell,
                        Data = data.Skip(1).Take(data[0] + (data[0] % 2 != 0 ? 1 : 0)).ToArray()
                    };
                case RealmsInstType.Sail:
                    return new RealmsSubTrans
                    {
                        Type = RealmsSubTransType.Sail,
                        Data = data.Skip(1).Take(data[0] + 8 + (data[0] % 2 != 0 ? 1 : 0)).ToArray()
                    };
                case RealmsInstType.Gamble:
                    return new RealmsSubTrans
                    {
                        Type = RealmsSubTransType.Gamble,
                        Data = data.Take((data[3] * 4) + (data[4] * 4) + 5).ToArray()
                    };
                default:
                    return null;
            }
        }
    }
}
