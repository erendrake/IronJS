// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.EqualityOperators
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheStrictDoesNotEqualsOperatorTests : SputnikTestFixture
    {
        public TheStrictDoesNotEqualsOperatorTests()
            : base(@"Conformance\11_Expressions\11.9_Equality_Operators\11.9.5_The_Strict_Does_not_equals_Operator")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S11.9.5_A1.js", Description = "White Space and Line Terminator between EqualityExpression and \"!==\" or between \"!==\" and RelationalExpression are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenEqualityExpressionAndOrBetweenAndRelationalExpressionAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [TestCase("S11.9.5_A2.1_T1.js", Description = "Operator x !== y uses GetValue")]
        [TestCase("S11.9.5_A2.1_T2.js", Description = "Operator x !== y uses GetValue")]
        [TestCase("S11.9.5_A2.1_T3.js", Description = "Operator x !== y uses GetValue")]
        public void OperatorXYUsesGetValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [TestCase("S11.9.5_A2.4_T1.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.9.5_A2.4_T2.js", Description = "First expression is evaluated first, and then second expression")]
        [TestCase("S11.9.5_A2.4_T3.js", Description = "First expression is evaluated first, and then second expression")]
        public void FirstExpressionIsEvaluatedFirstAndThenSecondExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 11.9.6")]
        [TestCase("S11.9.5_A3.js", Description = "Type(x) and Type(y) are Boolean-s. Return false, if x and y are both true or both false")]
        public void TypeXAndTypeYAreBooleanSReturnFalseIfXAndYAreBothTrueOrBothFalse(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 11.9.6")]
        [TestCase("S11.9.5_A4.1_T1.js", Description = "If x or y is NaN, return true")]
        [TestCase("S11.9.5_A4.1_T2.js", Description = "If x or y is NaN, return true")]
        public void IfXOrYIsNaNReturnTrue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 11.9.6")]
        [TestCase("S11.9.5_A4.2.js", Description = "If x is +0(-0) and y is -0(+0), return false")]
        public void IfXIs00AndYIs00ReturnFalse(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 11.9.6")]
        [TestCase("S11.9.5_A4.3.js", Description = "Type(x) and Type(y) are Number-s minus NaN, +0, -0. Return false, if x is the same number value as y")]
        public void TypeXAndTypeYAreNumberSMinusNaN00ReturnFalseIfXIsTheSameNumberValueAsY(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 11.9.6")]
        [TestCase("S11.9.5_A5.js", Description = "Type(x) and Type(y) are String-s. Return false, if x and y are exactly the same sequence of characters")]
        public void TypeXAndTypeYAreStringSReturnFalseIfXAndYAreExactlyTheSameSequenceOfCharacters(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 11.9.6")]
        [TestCase("S11.9.5_A6.1.js", Description = "If Type(x) and Type(y) are Undefined-s, return false")]
        public void IfTypeXAndTypeYAreUndefinedSReturnFalse(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 11.9.6")]
        [TestCase("S11.9.5_A6.2.js", Description = "If Type(x) and Type(y) are Null-s, return false")]
        public void IfTypeXAndTypeYAreNullSReturnFalse(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 11.9.6")]
        [TestCase("S11.9.5_A7.js", Description = "Type(x) and Type(y) are Object-s. Return false, if x and y are references to the same Object")]
        public void TypeXAndTypeYAreObjectSReturnFalseIfXAndYAreReferencesToTheSameObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.9.5")]
        [Category("ECMA 11.9.6")]
        [TestCase("S11.9.5_A8_T1.js", Description = "If Type(x) is different from Type(y), return true")]
        [TestCase("S11.9.5_A8_T2.js", Description = "If Type(x) is different from Type(y), return true")]
        [TestCase("S11.9.5_A8_T3.js", Description = "If Type(x) is different from Type(y), return true")]
        [TestCase("S11.9.5_A8_T4.js", Description = "If Type(x) is different from Type(y), return true")]
        [TestCase("S11.9.5_A8_T5.js", Description = "If Type(x) is different from Type(y), return true")]
        public void IfTypeXIsDifferentFromTypeYReturnTrue(string file)
        {
            RunFile(file);
        }
    }
}