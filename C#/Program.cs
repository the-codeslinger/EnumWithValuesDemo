using System;
using System.Collections.Generic;

namespace EnumWithValuesDemo
{
    public sealed class CharacterReplacementCode
    {
        public enum Type
        {
            Colon, Pound, QuestionMark
        }

        public static readonly CharacterReplacementCode Colon = new CharacterReplacementCode(Type.Colon, ":", "&58;");
        public static readonly CharacterReplacementCode Pound = new CharacterReplacementCode(Type.Pound, "#", "&35;");
        public static readonly CharacterReplacementCode QuestionMark = new CharacterReplacementCode(Type.QuestionMark, "?", "&63;");

        public static IEnumerable<CharacterReplacementCode> Values
        {
            get
            {
                yield return Pound;
                yield return Colon;
                yield return QuestionMark;
            }
        }

        public static implicit operator CharacterReplacementCode.Type(CharacterReplacementCode replacementCode) 
            => replacementCode.EnumType;

        public Type EnumType { get; private set; }
        public string Character { get; private set; }
        public string Replacement { get; private set; }

        CharacterReplacementCode(Type type, string character, string code) 
            => (EnumType, Character, Replacement) = (type, character, code);

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
                switch ((CharacterReplacementCode.Type)code) {
                    case CharacterReplacementCode.Type.Colon:
                        Console.WriteLine("COLON: " + code);
                        break;
                    case CharacterReplacementCode.Type.Pound:
                        Console.WriteLine("POUND: " + code);
                        break;
                    case CharacterReplacementCode.Type.QuestionMark:
                        Console.WriteLine("QUESTION: " + code);
                        break;
                }
            }
        }
    }
}
