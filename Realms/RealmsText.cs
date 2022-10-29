using System;
using System.Collections.Generic;
using System.Linq;

namespace Realms
{
    public class RealmsText
    {
        private static string[] SpecialCharsL = new string[] { " th", "he ", "the", "nd ", " a ", " yo", " to", "and", " an", "ou ", "ing", "is ", " of", "s a", "ng ", " in", 
                                                              "ed ", "re ", "The", "her", "er ", "in ", "es ", " he", "ere", "e a", "ll ", " is", "at ", "igh", "e ", " t" };
        private static string[] SpecialCharsH = new string[] { "s ", "he", " a", "th", "in", "t ", "d ", "ou", "er", " s", "re", "an", "n ", " i", " o", " w",
                                                              "nd", "ar", " h", ", ", "es", "or", "r ", " c", "y ", "at", "is", " f", "ea", "o ", "ng", "to",
                                                              "on", "st", "it", "ha", " b", "a ", "ll", "ve", " m", "ro", "le", "l ", "ed", "hi", "u ", "al",
                                                              "of", "te", ". ", "en", " l", " d", "Th", "el", " p", "ne", "as", "se", "ow", "me", "om", " r",
                                                              " g", " n", "ee", "h ", "ri", "de", "la", "ra", "nt", "ur", "li", "; ", "il", "co", "no", "ut",
                                                              "ce", " I", "oo", "ma", " e", "lo", "ti", "et", "k ", "so", "ta", "we", "be", "wi", "wa", "ns",
                                                              "m ", "ch", "ca", "fo", "ot", "ge", "ac", "gh", "ai", "av", "ie", "un", "ic", "ho", "ly", "sh",
                                                              "pe", "ad", "tr", "us", "ts", "rs", "bo", "mo", "qu", "ig", "ei", "ck", "am", "ss", "um", "ay" };

        public RealmsSector Sector { get; set; }
        public byte[] Data { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public static RealmsText GetText(byte[] data, int tOffset, int offset, int hOffset = 0)
        {
            var tData = GetData(data.Skip(offset).ToArray());
            return new RealmsText
            {
                Sector = RealmsSector.GetSector(offset - tOffset - hOffset),
                Data = tData,
                Text = GetText(tData)
            };
        }

        public static List<RealmsText> ReadTexts(byte[] data, int tOffset, ref int offset, int boundry, int hOffset = 0)
        {
            var texts = new List<RealmsText>();
            while(data[offset] != 0)
            {
                var text = GetText(data, tOffset, offset, hOffset);
                texts.Add(text);
                offset += text.Data.Length;
            }
            offset += RealmsSector.PadBoundry(offset, boundry);
            return texts;
        }

        private static byte[] GetData(byte[] data)
        {
            var tData = new List<byte>();
            var index = 0;
            while (data[index] != 127)
            {
                tData.Add(data[index++]);
            }
            tData.Add(data[index]);
            return tData.ToArray();
        }

        private static string GetString(byte b)
        {
            var value = "";

            if (b < 32)
            {
                value += SpecialCharsL[b];
            }
            else if (b > 127)
            {
                value += SpecialCharsH[b & 127];
            }
            else
            {
                value += Convert.ToChar(b);
            }

            return value;
        }

        private static string GetText(byte[] data)
        {
            var text = "";
            var index = 0;
            while (index < data.Length && data[index] != 127)
            {
                text += GetString(data[index++]);
            }
            return text;
        }
    }
}
