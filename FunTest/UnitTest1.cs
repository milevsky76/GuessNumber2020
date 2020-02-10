using System;
using NUnit;
using NUnit.Framework;

namespace FunTest
{
    public class UnitTest1
    {
        [Test]
        [TestCase(12, "Test")]
        [TestCase(30, "FunFUn")]
        public void Fun(int age, string name)
        {
            var a = 10 + 2;
            Assert.AreEqual(age, a);
        }
    }
}
