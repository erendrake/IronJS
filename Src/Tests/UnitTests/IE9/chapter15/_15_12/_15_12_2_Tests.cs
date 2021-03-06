// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter15._15_12
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _15_12_2_Tests : IE9TestFixture
    {
        public _15_12_2_Tests() : base(@"chapter15\15.12\15.12.2") { }

        [Test(Description = "JSON.parse must exist as a function")] public void _15_12_2__0__1() { RunFile(@"15.12.2-0-1.js"); }
        [Test(Description = "JSON.parse must exist as a function taking 2 parameters")] public void _15_12_2__0__2() { RunFile(@"15.12.2-0-2.js"); }
        [Test(Description = "JSON.parse must be deletable (configurable)")] public void _15_12_2__0__3() { RunFile(@"15.12.2-0-3.js"); }
        [Test(Description = "JSON.parse - parsing an object where property name is a null character")] public void _15_12_2__2__1() { RunFile(@"15.12.2-2-1.js"); }
        [Test(Description = "JSON.parse - parsing an object where property value middles with a null character")] public void _15_12_2__2__10() { RunFile(@"15.12.2-2-10.js"); }
        [Test(Description = "JSON.parse - parsing an object where property name starts with a null character")] public void _15_12_2__2__2() { RunFile(@"15.12.2-2-2.js"); }
        [Test(Description = "JSON.parse - parsing an object where property name ends with a null character")] public void _15_12_2__2__3() { RunFile(@"15.12.2-2-3.js"); }
        [Test(Description = "JSON.parse - parsing an object where property name starts and ends with a null character")] public void _15_12_2__2__4() { RunFile(@"15.12.2-2-4.js"); }
        [Test(Description = "JSON.parse - parsing an object where property name middles with a null character")] public void _15_12_2__2__5() { RunFile(@"15.12.2-2-5.js"); }
        [Test(Description = "JSON.parse - parsing an object where property value is a null character")] public void _15_12_2__2__6() { RunFile(@"15.12.2-2-6.js"); }
        [Test(Description = "JSON.parse - parsing an object where property value starts with a null character")] public void _15_12_2__2__7() { RunFile(@"15.12.2-2-7.js"); }
        [Test(Description = "JSON.parse - parsing an object where property value ends with a null character")] public void _15_12_2__2__8() { RunFile(@"15.12.2-2-8.js"); }
        [Test(Description = "JSON.parse - parsing an object where property value starts and ends with a null character")] public void _15_12_2__2__9() { RunFile(@"15.12.2-2-9.js"); }
    }
}