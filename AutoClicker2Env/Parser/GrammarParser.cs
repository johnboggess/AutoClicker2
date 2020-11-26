/*
 * GrammarParser.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using System.IO;

using PerCederberg.Grammatica.Runtime;

/**
 * <remarks>A token stream parser.</remarks>
 */
internal class GrammarParser : RecursiveDescentParser {

    /**
     * <summary>An enumeration with the generated production node
     * identity constants.</summary>
     */
    private enum SynteticPatterns {
        SUBPRODUCTION_1 = 3001,
        SUBPRODUCTION_2 = 3002,
        SUBPRODUCTION_3 = 3003,
        SUBPRODUCTION_4 = 3004,
        SUBPRODUCTION_5 = 3005,
        SUBPRODUCTION_6 = 3006,
        SUBPRODUCTION_7 = 3007,
        SUBPRODUCTION_8 = 3008,
        SUBPRODUCTION_9 = 3009,
        SUBPRODUCTION_10 = 3010,
        SUBPRODUCTION_11 = 3011
    }

    /**
     * <summary>Creates a new parser with a default analyzer.</summary>
     *
     * <param name='input'>the input stream to read from</param>
     *
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    public GrammarParser(TextReader input)
        : base(input) {

        CreatePatterns();
    }

    /**
     * <summary>Creates a new parser.</summary>
     *
     * <param name='input'>the input stream to read from</param>
     *
     * <param name='analyzer'>the analyzer to parse with</param>
     *
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    public GrammarParser(TextReader input, GrammarAnalyzer analyzer)
        : base(input, analyzer) {

        CreatePatterns();
    }

    /**
     * <summary>Creates a new tokenizer for this parser. Can be overridden
     * by a subclass to provide a custom implementation.</summary>
     *
     * <param name='input'>the input stream to read from</param>
     *
     * <returns>the tokenizer created</returns>
     *
     * <exception cref='ParserCreationException'>if the tokenizer
     * couldn't be initialized correctly</exception>
     */
    protected override Tokenizer NewTokenizer(TextReader input) {
        return new GrammarTokenizer(input);
    }

    /**
     * <summary>Initializes the parser by creating all the production
     * patterns.</summary>
     *
     * <exception cref='ParserCreationException'>if the parser
     * couldn't be initialized correctly</exception>
     */
    private void CreatePatterns() {
        ProductionPattern             pattern;
        ProductionPatternAlternative  alt;

        pattern = new ProductionPattern((int) GrammarConstants.PROGRAM,
                                        "Program");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.FUNCTION_DEF, 1, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.STATEMENT,
                                        "Statement");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.IF, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.WHILE, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_2, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.EXPRESSION,
                                        "Expression");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.EXPRESSION_NO_MATH, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.MATH_MODE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.EXPRESSION_NO_MATH,
                                        "ExpressionNoMath");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.VAR, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.LITERAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.FUNCTION_CALL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.VAR,
                                        "Var");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_3, 0, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.VAR_DELCARATION,
                                        "VarDelcaration");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.TYPE, 1, 1);
        alt.AddProduction((int) GrammarConstants.VAR, 1, 1);
        alt.AddToken((int) GrammarConstants.ASSIGNMENT, 1, 1);
        alt.AddProduction((int) GrammarConstants.EXPRESSION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.TYPE,
                                        "Type");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.STRINGKEYWORD, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.BOOLKEYWORD, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.NUMBERKEYWORD, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.VOIDKEYWORD, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.LITERAL,
                                        "Literal");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.TRUELITERAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.NUMBERLITERAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.FALSELITERAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.STRINGLITERAL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.IF,
                                        "If");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.IFKEYWORD, 1, 1);
        alt.AddToken((int) GrammarConstants.PARENTHESESLEFT, 1, 1);
        alt.AddProduction((int) GrammarConstants.EXPRESSION, 1, 1);
        alt.AddToken((int) GrammarConstants.PARENTHESESRIGHT, 1, 1);
        alt.AddToken((int) GrammarConstants.CURLYPARENTHESESLEFT, 1, 1);
        alt.AddProduction((int) GrammarConstants.STATEMENT, 0, -1);
        alt.AddToken((int) GrammarConstants.CURLYPARENTHESESRIGHT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.WHILE,
                                        "While");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.WHILEKEYWORD, 1, 1);
        alt.AddToken((int) GrammarConstants.PARENTHESESLEFT, 1, 1);
        alt.AddProduction((int) GrammarConstants.EXPRESSION, 1, 1);
        alt.AddToken((int) GrammarConstants.PARENTHESESRIGHT, 1, 1);
        alt.AddToken((int) GrammarConstants.CURLYPARENTHESESLEFT, 1, 1);
        alt.AddProduction((int) GrammarConstants.STATEMENT, 0, -1);
        alt.AddToken((int) GrammarConstants.CURLYPARENTHESESRIGHT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.FUNCTION_DEF,
                                        "FunctionDef");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.TYPE, 1, 1);
        alt.AddToken((int) GrammarConstants.IDENTIFIER, 1, 1);
        alt.AddToken((int) GrammarConstants.PARENTHESESLEFT, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_5, 0, 1);
        alt.AddToken((int) GrammarConstants.PARENTHESESRIGHT, 1, 1);
        alt.AddToken((int) GrammarConstants.CURLYPARENTHESESLEFT, 1, 1);
        alt.AddProduction((int) GrammarConstants.STATEMENT, 0, -1);
        alt.AddToken((int) GrammarConstants.CURLYPARENTHESESRIGHT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.FUNCTION_RETURN,
                                        "FunctionReturn");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.RETURNKEYWORD, 1, 1);
        alt.AddProduction((int) GrammarConstants.EXPRESSION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.FUNCTION_CALL,
                                        "FunctionCall");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.IDENTIFIER, 1, 1);
        alt.AddToken((int) GrammarConstants.PARENTHESESLEFT, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_7, 0, 1);
        alt.AddToken((int) GrammarConstants.PARENTHESESRIGHT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.MATH_MODE,
                                        "MathMode");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.MATHMODESYM, 1, 1);
        alt.AddProduction((int) GrammarConstants.MATH_EXPRESSION, 1, 1);
        alt.AddToken((int) GrammarConstants.MATHMODESYM, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.MATH_EXPRESSION,
                                        "MathExpression");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.MATH_TERM, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_9, 0, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.MATH_TERM,
                                        "MathTerm");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.NOT, 0, 1);
        alt.AddProduction((int) GrammarConstants.MATH_FACTOR, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_11, 0, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.MATH_FACTOR,
                                        "MathFactor");
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.EXPRESSION_NO_MATH, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.MATH_GROUP, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) GrammarConstants.MATH_GROUP,
                                        "MathGroup");
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.PARENTHESESLEFT, 1, 1);
        alt.AddProduction((int) GrammarConstants.MATH_EXPRESSION, 1, 1);
        alt.AddToken((int) GrammarConstants.PARENTHESESRIGHT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_1,
                                        "Subproduction1");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.VAR_DELCARATION, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.FUNCTION_RETURN, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.EXPRESSION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_2,
                                        "Subproduction2");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_1, 1, 1);
        alt.AddToken((int) GrammarConstants.ENDLINE, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_3,
                                        "Subproduction3");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.BRACKETLEFT, 1, 1);
        alt.AddProduction((int) GrammarConstants.EXPRESSION, 1, 1);
        alt.AddToken((int) GrammarConstants.BRACKETRIGHT, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_4,
                                        "Subproduction4");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.DELIMITER, 1, 1);
        alt.AddProduction((int) GrammarConstants.TYPE, 1, 1);
        alt.AddToken((int) GrammarConstants.IDENTIFIER, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_5,
                                        "Subproduction5");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.TYPE, 1, 1);
        alt.AddToken((int) GrammarConstants.IDENTIFIER, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_4, 0, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_6,
                                        "Subproduction6");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.DELIMITER, 1, 1);
        alt.AddProduction((int) GrammarConstants.EXPRESSION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_7,
                                        "Subproduction7");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) GrammarConstants.EXPRESSION, 1, 1);
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_6, 0, -1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_8,
                                        "Subproduction8");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.ADD, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.SUBTRACT, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.OR, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.AND, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.LESS, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.LESSEQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.GREATER, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.GREATEREQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.NOTEQUAL, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.EQUAL, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_9,
                                        "Subproduction9");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_8, 1, 1);
        alt.AddProduction((int) GrammarConstants.MATH_TERM, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_10,
                                        "Subproduction10");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.MULTIPLY, 1, 1);
        pattern.AddAlternative(alt);
        alt = new ProductionPatternAlternative();
        alt.AddToken((int) GrammarConstants.DIVISION, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);

        pattern = new ProductionPattern((int) SynteticPatterns.SUBPRODUCTION_11,
                                        "Subproduction11");
        pattern.Synthetic = true;
        alt = new ProductionPatternAlternative();
        alt.AddProduction((int) SynteticPatterns.SUBPRODUCTION_10, 1, 1);
        alt.AddToken((int) GrammarConstants.NOT, 0, 1);
        alt.AddProduction((int) GrammarConstants.MATH_FACTOR, 1, 1);
        pattern.AddAlternative(alt);
        AddPattern(pattern);
    }
}
