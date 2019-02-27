using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 3;
            bool asp = true;
            bool ott = Equazioni.IsDetermined(a);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double a = -3;
            bool asp = true;
            bool ott = Equazioni.IsDetermined(a);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double a = 0;
            bool asp = false;
            bool ott = Equazioni.IsDetermined(a);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestIns1()
        {
            double a = 5;
            double b = 0;
            bool asp = false;
            bool ott = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestIns2()
        {
            double a = 0;
            double b = 5;
            bool asp = false;
            bool ott = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestIns3()
        {
            double a = 5;
            double b = 5;
            bool asp = false;
            bool ott = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestIns4()
        {
            double a = 0;
            double b = 0;
            bool asp = true;
            bool ott = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(asp, ott);
        }
        [TestMethod]
        public void TestSec()
        {
            double a = 6;
            bool asp = true;
            bool ott = Equazioni.IsDegree2(a);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestSec2()
        {
            double a = 0;
            bool asp = false;
            bool ott = Equazioni.IsDegree2(a);

            Assert.AreEqual(asp, ott);
        }
    }
}
