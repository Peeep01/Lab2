using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Tests
{
    [TestClass()]
    public class ItogTests
    {
        [TestMethod()]
        
        public void chekTest()
        {
            Itog itog = new Itog();
            int varplayer1 = 63;
            int varplayer2 = 1023;
            string expected = "Вы проиграли(";
            string actual = itog.chek(varplayer1, varplayer2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void chekTest2()
        {
            Itog itog = new Itog();
            int varplayer1 = 1023;
            int varplayer2 = 63;
            string expected = "Вы победили!";
            string actual = itog.chek(varplayer1, varplayer2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void chekTest3()
        {
            Itog itog = new Itog();
            int varplayer1 = 1023;
            int varplayer2 = 1023;
            string expected = "Ничья";
            string actual = itog.chek(varplayer1, varplayer2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void chekTest4()
        {
            Itog itog = new Itog();
            int varplayer1 = -1023;
            int varplayer2 = -63;
            string expected = "Ошибка, программа не может выполнить команду";
            string actual = itog.chek(varplayer1, varplayer2);
            Assert.AreEqual(expected, actual);
        }
    }
}