using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringLib;

namespace StringLibTest
{
    [TestClass]
    public class StringClassTest
    {
        [TestMethod]
        public void vvoddatatrash()
        {
            ///Arrange
            string textString = "2006.05.30";

            ///Act

            bool atual = StringClass.StringParse(textString, 1);
            ///Assert
            Assert.IsTrue(atual);

        }
        [TestMethod]
        public void vvoddatatrash1()
        {
            ///Arrange
            string textString = "2006-05-30";

            ///Act

            bool atual = StringClass.StringParse(textString, 2);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash2()
        {
            ///Arrange
            string textString = "2006/05/30";

            ///Act

            bool atual = StringClass.StringParse(textString, 3);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash3()
        {
            ///Arrange
            string textString = "2006-5-30";

            ///Act

            bool atual = StringClass.StringParse(textString, 4);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash4()
        {
            ///Arrange
            string textString = "2006/5/30";

            ///Act

            bool atual = StringClass.StringParse(textString, 5);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash5()
        {
            ///Arrange
            string textString = "2006.30.05";

            ///Act

            bool atual = StringClass.StringParse(textString, 6);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash6()
        {
            ///Arrange
            string textString = "30.5.2006";

            ///Act

            bool atual = StringClass.StringParse(textString, 7);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash7()
        {
            ///Arrange
            string textString = "30-5-2006";

            ///Act

            bool atual = StringClass.StringParse(textString, 8);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash8()
        {
            ///Arrange
            string textString = "3-5-2006";

            ///Act

            bool atual = StringClass.StringParse(textString, 9);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash9()
        {
            ///Arrange
            string textString = "30/5/2006";

            ///Act

            bool atual = StringClass.StringParse(textString, 10);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash10()
        {
            ///Arrange
            string textString = "30.05.2006";

            ///Act

            bool atual = StringClass.StringParse(textString, 11);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash11()
        {
            ///Arrange
            string textString = "30-05-2006";

            ///Act

            bool atual = StringClass.StringParse(textString, 12);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash12()
        {
            ///Arrange
            string textString = "30/05/2006";

            ///Act

            bool atual = StringClass.StringParse(textString, 13);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash13()
        {
            ///Arrange
            string textString = "5/30/2006";

            ///Act

            bool atual = StringClass.StringParse(textString, 14);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash14()
        {
            ///Arrange
            string textString = "";

            ///Act

            bool atual = StringClass.StringParse(textString, 15);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash15()
        {
            ///Arrange
            string textString = "01.01.1970";

            ///Act

            bool atual = StringClass.StringParse(textString, 16);
            ///Assert
            Assert.IsTrue(atual);

        }

        [TestMethod]
        public void vvoddatatrash16()
        {
            ///Arrange
            string textString = "01.01.1900";

            ///Act

            bool atual = StringClass.StringParse(textString, 17);
            ///Assert
            Assert.IsTrue(atual);

        }


    }
}
