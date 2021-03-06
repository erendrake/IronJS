// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter10
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _10_6_Tests : IE9TestFixture
    {
        public _10_6_Tests() : base(@"chapter10\10.6") { }

        [Test(Description = "arguments[i] change with actual parameters")] public void _10_6__10__c__ii__1() { RunFile(@"10.6-10-c-ii-1.js"); }
        [Test(Description = "arguments[i] map to actual parameter")] public void _10_6__10__c__ii__2() { RunFile(@"10.6-10-c-ii-2.js"); }
        [Test(Description = "Arguments Object has index property \'0\' as its own property, it shoulde be writable, enumerable, configurable and does not invoke the setter defined on Object.prototype[0] (Step 11.b)")] public void _10_6__11__b__1() { RunFile(@"10.6-11-b-1.js"); }
        [Test(Description = "Accessing callee property of Arguments object is allowed")] public void _10_6__12__1() { RunFile(@"10.6-12-1.js"); }
        [Test(Description = "arguments.callee has correct attributes")] public void _10_6__12__2() { RunFile(@"10.6-12-2.js"); }
        [Test(Description = "Accessing caller property of Arguments object is allowed")] public void _10_6__13__1() { RunFile(@"10.6-13-1.js"); }
        [Test(Description = "In non-strict mode, arguments object should have its own \'callee\' property defined (Step 13.a)")] public void _10_6__13__a__1() { RunFile(@"10.6-13-a-1.js"); }
        [Test(Description = "[[Prototype]] property of Arguments is set to Object prototype object")] public void _10_6__5__1() { RunFile(@"10.6-5-1.js"); }
        [Test(Description = "\'length property of arguments object exists")] public void _10_6__6__1() { RunFile(@"10.6-6-1.js"); }
        [Test(Description = "\'length\' property of arguments object has correct attributes")] public void _10_6__6__2() { RunFile(@"10.6-6-2.js"); }
        [Test(Description = "\'length\' property of arguments object for 0 argument function exists")] public void _10_6__6__3() { RunFile(@"10.6-6-3.js"); }
        [Test(Description = "\'length\' property of arguments object for 0 argument function call is 0 even with formal parameters")] public void _10_6__6__4() { RunFile(@"10.6-6-4.js"); }
        [Test(Description = "Arguments Object has length as its own property and does not invoke the setter defined on Object.prototype.length (Step 7)")] public void _10_6__7__1() { RunFile(@"10.6-7-1.js"); }
    }
}