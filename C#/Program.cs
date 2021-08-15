using System;
using System.Collections.Generic;

namespace EnumWithValuesDemo
{
    public sealed class CharacterReplacementCode
    {
        public static readonly CharacterReplacementCode Colon = new CharacterReplacementCode(":", "&58;");
        public static readonly CharacterReplacementCode Pound = new CharacterReplacementCode("#", "&35;");
        public static readonly CharacterReplacementCode QuestionMark = new CharacterReplacementCode("?", "&63;");

        public static IEnumerable<CharacterReplacementCode> Values
        {
            get
            {
                yield return Pound;
                yield return Colon;
                yield return QuestionMark;
            }
        }

        public string Character { get; private set; }
        public string Replacement { get; private set; }

        CharacterReplacementCode(string character, string code) => (Character, Replacement) = (character, code);

        public override string ToString()
        {
            return $"Character '{Character}' substituted by code '{Replacement}'";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            foreach (var code in CharacterReplacementCode.Values) {
                switch (code) {
                    case CharacterReplacementCode { Character: ":"  }:
                        Console.WriteLine("COLON: " + code);
                        break;
                    case CharacterReplacementCode { Character: "#" }:
                        Console.WriteLine("POUND: " + code);
                        break;
                    case CharacterReplacementCode { Character: "?" }:
                        Console.WriteLine("QUESTION: " + code);
                        break;
                }
            }
        }
    }
}
