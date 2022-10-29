using System.Collections.Generic;
using System.Text;

namespace Realms
{
    public class RealmsState
    {
        public const int OffsetStates = 6229;

        public string Description { get; set; }
        public int Value { get; set; }

        public static List<string> LoadStates(byte[] data)
        {
            var states = new List<string>();
            var offset = OffsetStates;
            var count = 0;
            var state = "";
            while (count < 24)
            {
                state += Encoding.Default.GetString(new[] { (byte)(data[offset] & 127) });
                if ((data[offset++] & 128) == 128)
                {
                    states.Add(state[0].ToString().ToUpper() + state.Substring(1));
                    state = "";
                    count++;
                }
            }
            return states;
        }
    }
}
