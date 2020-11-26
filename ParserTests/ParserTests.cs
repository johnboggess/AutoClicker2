using System.IO;

using NUnit.Framework;

using PerCederberg.Grammatica.Runtime;
namespace ParserTests
{
    public class ParserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VarDelcarationTests()
        {
            string str = @"
void func() {
string a = true;
}";
            Parser parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
string a1 = true;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
string ab1 = true;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();


            str = @"
void func() {
string ab12 = true;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
bool ab12 = true;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12 = true;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();


            str = @"void func() {
number ab12 = false;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();


            str = @"
void func() { 
number ab12 = 0;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12 = -0;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"void func() {
number ab12 = -23;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"void func() {
number ab12 = 23;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12 = -0.;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12 = -.0;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12 = -23.;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12 = -23.543;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();


            str = @"
void func() {
number ab12 = ""asdasda"";
}"; ;
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();
            try
            {
                str = @"
void func() { 
string ab3.14 = true;
}";
                parser = new GrammarParser(new StringReader(str));
                parser.Parse();
                Assert.Fail();
            }
            catch { }


            str = @"
void func() {
number ab12 = vd323;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();


            str = @"
void func() { 
number ab12 = funCall(1);
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12 = funcCall(1,abc,""asd"", func());
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12 = funcCall(1,abc,""asd"", func(true));
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();


            str = @"
void func() {
number ab12[0] = vd323;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12[0] = vd323[1];
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
number ab12[9] = funcCall(1,abc,""asd"", func(abc[0]));
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();
        }

        [Test]
        public void IfTests()
        {
            string str = @"void func() {
if(true)
{
} }";
            Parser parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"void func() {
if(true)
{
    number ab12 = vd323;
} }";

            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
if(true)
{
    if(true)
    {
    }
}}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
if(true)
{
    number ab12 = vd323;
    if(true)
    {
    number ab12 = vd323;
    }
}}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
if(abc)
{
    number ab12 = vd323;
    if(abc123)
    {
    number ab12 = vd323;
    }
}}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();
        }

        [Test]
        public void WhileTests()
        {
            string str = @"
void func() {
while(true)
{
}}";
            Parser parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
while(true)
{
    number ab12 = vd323;
}}";

            parser = new GrammarParser(new StringReader(str));
            parser.Parse();
            str = @"
void func() {
while(true)
{
    while(true)
    {
    }
}}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
while(true)
{
    number ab12 = vd323;
    while(true)
    {
        number ab12 = vd323;
    }
}}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
while(abc)
{
    number ab12 = vd323;
    while(abc123)
    {
        number ab12 = vd323;
    }
}}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();
        }

        [Test]
        public void FunctionDef()
        {
            string str = @"void funcName() {}";
            Parser parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"void funcName() { func(); }";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"void funcName(bool a) {}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"void funcName(bool a, bool b, number c, string d) {}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"void funcName(bool a, bool b, number c, string d) 
{
    while(abc)
    {
        number ab12 = vd323;
        while(abc123)
        {
            number ab12 = vd323;
        }
    }
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();


            str = @"void funcName(bool a, bool b, number c, string d) 
{
    while(abc)
    {
        number ab12 = vd323;
        while(abc123)
        {
            number ab12 = vd323;
            return ab12;
        }
        return ab12;
    }
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();
        }

        [Test]
        public void MathExpression()
        {
            string str = @"
void func() {
string a = $1 + 1$;
}";
            Parser parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
string a = $1 + 1 - 1$;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
string a = $1 + 1/2 - 1$;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
string a = $(1+1)$;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() { 
string a = $1+(1+1)$;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
string a = $1 + 1/(2+1) - 1$;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
string a = $1 + b - func(12) * 0.0 + (0 * 1)$;
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"
void func() {
string a[$1*ab$] = func($1+1$);
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();


            str = @"
void func() { 
string a[$!1|ab$] = func($1&1$);
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();
        }

        [Test]
        public void Program()
        {
            string str = @"void funcName(bool a) {}";
            Parser parser = new GrammarParser(new StringReader(str));
            parser.Parse();

            str = @"void funcName(bool a) {}
void funcName(bool a, bool b, number c, string d) 
{
}";
            parser = new GrammarParser(new StringReader(str));
            parser.Parse();
        }
    }

}