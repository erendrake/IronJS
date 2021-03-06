// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheDateConstructorTests : SputnikTestFixture
    {
        public TheDateConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.3_The_Date_Constructor")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.3.1")]
        [TestCase("S15.9.3.1_A1_T1.js", Description = "When Date is called as part of a new expression it is a constructor: it initializes the newly created object")]
        [TestCase("S15.9.3.1_A1_T2.js", Description = "When Date is called as part of a new expression it is a constructor: it initializes the newly created object")]
        [TestCase("S15.9.3.1_A1_T3.js", Description = "When Date is called as part of a new expression it is a constructor: it initializes the newly created object")]
        [TestCase("S15.9.3.1_A1_T4.js", Description = "When Date is called as part of a new expression it is a constructor: it initializes the newly created object")]
        [TestCase("S15.9.3.1_A1_T5.js", Description = "When Date is called as part of a new expression it is a constructor: it initializes the newly created object")]
        [TestCase("S15.9.3.1_A1_T6.js", Description = "When Date is called as part of a new expression it is a constructor: it initializes the newly created object")]
        public void WhenDateIsCalledAsPartOfANewExpressionItIsAConstructorItInitializesTheNewlyCreatedObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.3.1")]
        [Category("ECMA 15.9.3.2")]
        [TestCase("S15.9.3.1_A2_T1.js", Description = "The [[Prototype]] property of the newly constructed object is set to the original Date prototype object, the one that is the initial value of Date.prototype")]
        [TestCase("S15.9.3.1_A2_T2.js", Description = "The [[Prototype]] property of the newly constructed object is set to the original Date prototype object, the one that is the initial value of Date.prototype")]
        [TestCase("S15.9.3.1_A2_T3.js", Description = "The [[Prototype]] property of the newly constructed object is set to the original Date prototype object, the one that is the initial value of Date.prototype")]
        [TestCase("S15.9.3.1_A2_T4.js", Description = "The [[Prototype]] property of the newly constructed object is set to the original Date prototype object, the one that is the initial value of Date.prototype")]
        [TestCase("S15.9.3.1_A2_T5.js", Description = "The [[Prototype]] property of the newly constructed object is set to the original Date prototype object, the one that is the initial value of Date.prototype")]
        [TestCase("S15.9.3.1_A2_T6.js", Description = "The [[Prototype]] property of the newly constructed object is set to the original Date prototype object, the one that is the initial value of Date.prototype")]
        [TestCase("S15.9.3.2_A2_T1.js", Description = "The [[Prototype]] property of the newly constructed object is set to the original Date prototype object, the one that is the initial value of Date.prototype")]
        public void ThePrototypePropertyOfTheNewlyConstructedObjectIsSetToTheOriginalDatePrototypeObjectTheOneThatIsTheInitialValueOfDatePrototype(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.3.1")]
        [Category("ECMA 15.9.3.2")]
        [TestCase("S15.9.3.1_A3_T1.1.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T1.2.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T2.1.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T2.2.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T3.1.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T3.2.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T4.1.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T4.2.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T5.1.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T5.2.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T6.1.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.1_A3_T6.2.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.2_A3_T1.1.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        [TestCase("S15.9.3.2_A3_T1.2.js", Description = "The [[Class]] property of the newly constructed object is set to \"Date\"")]
        public void TheClassPropertyOfTheNewlyConstructedObjectIsSetToDate(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.3.1")]
        [TestCase("S15.9.3.1_A4_T1.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 1. Call ToNumber(year) 2. Call ToNumber(month) 3. If date is supplied use ToNumber(date) 4. If hours is supplied use ToNumber(hours) 5. If minutes is supplied use ToNumber(minutes) 6. If seconds is supplied use ToNumber(seconds) 7. If ms is supplied use ToNumber(ms)")]
        [TestCase("S15.9.3.1_A4_T2.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 1. Call ToNumber(year) 2. Call ToNumber(month) 3. If date is supplied use ToNumber(date) 4. If hours is supplied use ToNumber(hours) 5. If minutes is supplied use ToNumber(minutes) 6. If seconds is supplied use ToNumber(seconds) 7. If ms is supplied use ToNumber(ms)")]
        [TestCase("S15.9.3.1_A4_T3.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 1. Call ToNumber(year) 2. Call ToNumber(month) 3. If date is supplied use ToNumber(date) 4. If hours is supplied use ToNumber(hours) 5. If minutes is supplied use ToNumber(minutes) 6. If seconds is supplied use ToNumber(seconds) 7. If ms is supplied use ToNumber(ms)")]
        [TestCase("S15.9.3.1_A4_T4.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 1. Call ToNumber(year) 2. Call ToNumber(month) 3. If date is supplied use ToNumber(date) 4. If hours is supplied use ToNumber(hours) 5. If minutes is supplied use ToNumber(minutes) 6. If seconds is supplied use ToNumber(seconds) 7. If ms is supplied use ToNumber(ms)")]
        [TestCase("S15.9.3.1_A4_T5.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 1. Call ToNumber(year) 2. Call ToNumber(month) 3. If date is supplied use ToNumber(date) 4. If hours is supplied use ToNumber(hours) 5. If minutes is supplied use ToNumber(minutes) 6. If seconds is supplied use ToNumber(seconds) 7. If ms is supplied use ToNumber(ms)")]
        [TestCase("S15.9.3.1_A4_T6.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 1. Call ToNumber(year) 2. Call ToNumber(month) 3. If date is supplied use ToNumber(date) 4. If hours is supplied use ToNumber(hours) 5. If minutes is supplied use ToNumber(minutes) 6. If seconds is supplied use ToNumber(seconds) 7. If ms is supplied use ToNumber(ms)")]
        [TestCase("S15.9.3.1_A5_T1.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 8. If Result(1) is not NaN and 0 <= ToInteger(Result(1)) <= 99, Result(8) is 1900+ToInteger(Result(1))")]
        [TestCase("S15.9.3.1_A5_T2.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 8. If Result(1) is not NaN and 0 <= ToInteger(Result(1)) <= 99, Result(8) is 1900+ToInteger(Result(1))")]
        [TestCase("S15.9.3.1_A5_T3.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 8. If Result(1) is not NaN and 0 <= ToInteger(Result(1)) <= 99, Result(8) is 1900+ToInteger(Result(1))")]
        [TestCase("S15.9.3.1_A5_T4.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 8. If Result(1) is not NaN and 0 <= ToInteger(Result(1)) <= 99, Result(8) is 1900+ToInteger(Result(1))")]
        [TestCase("S15.9.3.1_A5_T5.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 8. If Result(1) is not NaN and 0 <= ToInteger(Result(1)) <= 99, Result(8) is 1900+ToInteger(Result(1))")]
        [TestCase("S15.9.3.1_A5_T6.js", Description = "The [[Value]] property of the newly constructed object is set by following steps: 8. If Result(1) is not NaN and 0 <= ToInteger(Result(1)) <= 99, Result(8) is 1900+ToInteger(Result(1))")]
        public void TheValuePropertyOfTheNewlyConstructedObjectIsSetByFollowingSpecificSteps(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.3.1")]
        [TestCase("S15.9.3.1_A6_T1.js", Description = "The [[Value]] property of the newly constructed object with supplied \"undefined\" argument should be NaN")]
        [TestCase("S15.9.3.1_A6_T2.js", Description = "The [[Value]] property of the newly constructed object with supplied \"undefined\" argument should be NaN")]
        [TestCase("S15.9.3.1_A6_T3.js", Description = "The [[Value]] property of the newly constructed object with supplied \"undefined\" argument should be NaN")]
        [TestCase("S15.9.3.1_A6_T4.js", Description = "The [[Value]] property of the newly constructed object with supplied \"undefined\" argument should be NaN")]
        [TestCase("S15.9.3.1_A6_T5.js", Description = "The [[Value]] property of the newly constructed object with supplied \"undefined\" argument should be NaN")]
        public void TheValuePropertyOfTheNewlyConstructedObjectWithSuppliedUndefinedArgumentShouldBeNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.3.2")]
        [TestCase("S15.9.3.2_A1_T1.js", Description = "When Date is called as part of a new expression it is a constructor: it initialises the newly created object")]
        public void WhenDateIsCalledAsPartOfANewExpressionItIsAConstructorItInitialisesTheNewlyCreatedObject(string file)
        {
            RunFile(file);
        }
    }
}