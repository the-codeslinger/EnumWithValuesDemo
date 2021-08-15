package com.thecodeslinger;

import lombok.Getter;
import lombok.RequiredArgsConstructor;

import java.util.stream.Stream;

public class EnumWithValuesDemo {

    @Getter
    @RequiredArgsConstructor
    enum CharacterReplacementCode  {

        COLON(":", "&58;"),
        POUND("#", "&35;"),
        QUESTION_MARK("?", "&63;");

        private final String character;
        private final String replacement;

        @Override
        public String toString() {
            return String.format("Character '%s' substituted by code '%s'", character, replacement);
        }
    }

    public static void main(String[] args) {
        System.out.println("Shite");

        Stream.of(CharacterReplacementCode.values()).forEach(code -> {
            switch (code) {
                case COLON:
                    System.out.println("COLON - " + code);
                    break;
                case POUND:
                    System.out.println("POUND - " + code);
                    break;
                case QUESTION_MARK:
                    System.out.println("QUESTION - " + code);
                    break;
            }
        });
    }
}