using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_2017_10_22;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 1;
            string actual = Program.CowCounter(n);
            string expected = "1 корова";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod11()
        {
            int n = 11;
            string actual = Program.CowCounter(n);
            string expected = "11 коров";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int n=3;
            string actual = Program.CowCounter(n);
            string expected = "3 коровы";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int n = 6;
            string actual = Program.CowCounter(n);
            string expected = "6 коров";
            Assert.AreEqual(expected, actual);
        }
    }
}
