/*
 * GrammarTokenizer.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using System.IO;

using PerCederberg.Grammatica.Runtime;

/**
 * <remarks>A character stream tokenizer.</remarks>
 */
internal class GrammarTokenizer : Tokenizer {

    /**
     * <summary>Creates a new tokenizer for the specified input
     * stream.</summary>
     *
     * <param name='input'>the input stream to read</param>
     *
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    public GrammarTokenizer(TextReader input)
        : base(input, false) {

        CreatePatterns();
    }

    /**
     * <summary>Initializes the tokenizer by creating all the token
     * patterns.</summary>
     *
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    private void CreatePatterns() {
        TokenPattern  pattern;

        pattern = new TokenPattern((int) GrammarConstants.STRINGKEYWORD,
                                   "STRINGKEYWORD",
                                   TokenPattern.PatternType.STRING,
                                   "string");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.BOOLKEYWORD,
                                   "BOOLKEYWORD",
                                   TokenPattern.PatternType.STRING,
                                   "bool");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.NUMBERKEYWORD,
                                   "NUMBERKEYWORD",
                                   TokenPattern.PatternType.STRING,
                                   "number");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.VOIDKEYWORD,
                                   "VOIDKEYWORD",
                                   TokenPattern.PatternType.STRING,
                                   "void");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.IFKEYWORD,
                                   "IFKEYWORD",
                                   TokenPattern.PatternType.STRING,
                                   "if");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.WHILEKEYWORD,
                                   "WHILEKEYWORD",
                                   TokenPattern.PatternType.STRING,
                                   "while");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.RETURNKEYWORD,
                                   "RETURNKEYWORD",
                                   TokenPattern.PatternType.STRING,
                                   "return");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.OR,
                                   "OR",
                                   TokenPattern.PatternType.STRING,
                                   "|");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.AND,
                                   "AND",
                                   TokenPattern.PatternType.STRING,
                                   "&");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.NOT,
                                   "NOT",
                                   TokenPattern.PatternType.STRING,
                                   "!");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.LESS,
                                   "LESS",
                                   TokenPattern.PatternType.STRING,
                                   "<");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.LESSEQUAL,
                                   "LESSEQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "<=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.GREATER,
                                   "GREATER",
                                   TokenPattern.PatternType.STRING,
                                   ">");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.GREATEREQUAL,
                                   "GREATEREQUAL",
                                   TokenPattern.PatternType.STRING,
                                   ">=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.NOTEQUAL,
                                   "NOTEQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "!=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.EQUAL,
                                   "EQUAL",
                                   TokenPattern.PatternType.STRING,
                                   "==");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.ASSIGNMENT,
                                   "ASSIGNMENT",
                                   TokenPattern.PatternType.STRING,
                                   "=");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.PARENTHESESLEFT,
                                   "PARENTHESESLEFT",
                                   TokenPattern.PatternType.STRING,
                                   "(");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.PARENTHESESRIGHT,
                                   "PARENTHESESRIGHT",
                                   TokenPattern.PatternType.STRING,
                                   ")");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.CURLYPARENTHESESLEFT,
                                   "CURLYPARENTHESESLEFT",
                                   TokenPattern.PatternType.STRING,
                                   "{");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.CURLYPARENTHESESRIGHT,
                                   "CURLYPARENTHESESRIGHT",
                                   TokenPattern.PatternType.STRING,
                                   "}");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.BRACKETLEFT,
                                   "BRACKETLEFT",
                                   TokenPattern.PatternType.STRING,
                                   "[");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.BRACKETRIGHT,
                                   "BRACKETRIGHT",
                                   TokenPattern.PatternType.STRING,
                                   "]");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.ENDLINE,
                                   "ENDLINE",
                                   TokenPattern.PatternType.STRING,
                                   ";");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.DELIMITER,
                                   "DELIMITER",
                                   TokenPattern.PatternType.STRING,
                                   ",");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.MATHMODESYM,
                                   "MATHMODESYM",
                                   TokenPattern.PatternType.STRING,
                                   "$");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.ADD,
                                   "ADD",
                                   TokenPattern.PatternType.STRING,
                                   "+");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.SUBTRACT,
                                   "SUBTRACT",
                                   TokenPattern.PatternType.STRING,
                                   "-");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.MULTIPLY,
                                   "MULTIPLY",
                                   TokenPattern.PatternType.STRING,
                                   "*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.DIVISION,
                                   "DIVISION",
                                   TokenPattern.PatternType.STRING,
                                   "/");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.NUMBERLITERAL,
                                   "NUMBERLITERAL",
                                   TokenPattern.PatternType.REGEXP,
                                   "[-]?[0-9]*[.]?[0-9]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.TRUELITERAL,
                                   "TRUELITERAL",
                                   TokenPattern.PatternType.STRING,
                                   "true");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.FALSELITERAL,
                                   "FALSELITERAL",
                                   TokenPattern.PatternType.STRING,
                                   "false");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.STRINGLITERAL,
                                   "STRINGLITERAL",
                                   TokenPattern.PatternType.REGEXP,
                                   "\".*\"");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.IDENTIFIER,
                                   "IDENTIFIER",
                                   TokenPattern.PatternType.REGEXP,
                                   "[a-zA-Z][a-zA-Z0-9]*");
        AddPattern(pattern);

        pattern = new TokenPattern((int) GrammarConstants.WHITESPACE,
                                   "WHITESPACE",
                                   TokenPattern.PatternType.REGEXP,
                                   "[ \\t\\n\\r]+");
        pattern.Ignore = true;
        AddPattern(pattern);
    }
}
