// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter15._15_11._15_11_4
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _15_11_4_4_Tests : IE9TestFixture
    {
        public _15_11_4_4_Tests() : base(@"chapter15\15.11\15.11.4\15.11.4.4") { }

        [Test(Description = "Error.prototype.toString return the result of concatenating \'name\', \':\', a single space character, and \'msg\' when \'name\' and \'msg\' are non-empty string")] public void _15_11_4_4__10__1() { RunFile(@"15.11.4.4-10-1.js"); }
        [Test(Description = "Error.prototype.toString - \'Error\' is returned when \'name\' is absent and empty string is returned when \'msg\' is undefined")] public void _15_11_4_4__6__1() { RunFile(@"15.11.4.4-6-1.js"); }
        [Test(Description = "Error.prototype.toString - \'Error\' is returned when \'name\' is absent and value of \'msg\' is returned when \'msg\' is non-empty string")] public void _15_11_4_4__6__2() { RunFile(@"15.11.4.4-6-2.js"); }
        [Test(Description = "Error.prototype.toString return the value of \'msg\' when \'name\' is empty string and \'msg\' isn\'t undefined")] public void _15_11_4_4__8__1() { RunFile(@"15.11.4.4-8-1.js"); }
        [Test(Description = "Error.prototype.toString return empty string when \'name\' is empty string and \'msg\' is undefined")] public void _15_11_4_4__8__2() { RunFile(@"15.11.4.4-8-2.js"); }
        [Test(Description = "Error.prototype.toString return \'name\' when \'name\' is non-empty string and \'msg\' is empty string")] public void _15_11_4_4__9__1() { RunFile(@"15.11.4.4-9-1.js"); }
    }
}