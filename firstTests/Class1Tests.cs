using Microsoft.VisualStudio.TestTools.UnitTesting;
using first;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void Ch0of5()
        {
            string password = "";
            int ball = 5;

            Class1 cha = new Class1();
            int actual = cha.Ch(password);

            Assert.AreEqual(ball, actual);
        }
        [TestMethod()]
        public void CH1of5()
        {
            string password = "1";
            int ball = 5;
            Class1 cha = new Class1();
            int actual = cha.Ch(password);

            Assert.AreEqual(ball, actual);
        }
        [TestMethod()]
        public void CH2of5()
        {
            string password = "1a";
            int ball = 5;
            Class1 cha = new Class1();
            int actual = cha.Ch(password);

            Assert.AreEqual(ball, actual);
        }
        [TestMethod()]
        public void CH3of5()
        {
            string password = "1aA";
            int ball = 5;
            Class1 cha = new Class1();
            int actual = cha.Ch(password);

            Assert.AreEqual(ball, actual);
        }
        [TestMethod()]
        public void CH4of5()
        {
            string password = "1aA.";
            int ball = 5;
            Class1 cha = new Class1();
            int actual = cha.Ch(password);

            Assert.AreEqual(ball, actual);
        }
        [TestMethod()]
        public void CH5of5()
        {
            string password = "1aA.aaaaaaaa";
            int ball = 5;
            Class1 cha = new Class1();
            int actual = cha.Ch(password);

            Assert.AreEqual(ball, actual);
        }
    }
}