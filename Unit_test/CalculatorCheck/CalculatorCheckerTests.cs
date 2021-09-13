using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void validateCalculatorTestPlusTrue()
        {
            // Arrange
            int chislo1=5;
            int chislo2=5;
            int result = 10;
            string op = "+";
            bool expected = true;
            //Act
            bool actual = CalculatorChecker.validateCalculator(chislo1, chislo2, op, result);
            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void validateCalculatorTestPlusFalse()
        {
            // Arrange
            int chislo1 = 2;
            int chislo2 = 2;
            int result = 5;
            string op = "+";
            bool expected = false;
            //Act
            bool actual = CalculatorChecker.validateCalculatorfalse(chislo1, chislo2, op, result);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void validateCalculatorTestMultiplyTrue()
        {
            // Arrange
            int chislo1 = 10;
            int chislo2 = 10;
            int result = 100;
            string op = "*";
            bool expected = true;
            //Act
            bool actual = CalculatorChecker.validateCalculatormultiplytrue(chislo1, chislo2, op, result);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void validateCalculatorTestMultiplyFalse()
        {
            // Arrange
            int chislo1 = 10;
            int chislo2 = 10;
            int result = 101;
            string op = "*";
            bool expected = false;
            //Act
            bool actual = CalculatorChecker.validateCalculatormultiplyfalse(chislo1, chislo2, op, result);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void validateCalculatorminusfalse()
        {
            // Arrange
            int chislo1 = 12;
            int chislo2 = 10;
            int result = 1;
            string op = "-";
            bool expected = false;
            //Act
            bool actual = CalculatorChecker.validateCalculatorminusfalse(chislo1, chislo2, op, result);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void validateCalculatorminustrue()
        {
            // Arrange
            int chislo1 = 12;
            int chislo2 = 10;
            int result = 2;
            string op = "-";
            bool expected = true;
            //Act
            bool actual = CalculatorChecker.validateCalculatorminustrue(chislo1, chislo2, op, result);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void validateCalculatordivisiontrue()
        {
            // Arrange
            int chislo1 = 12;
            int chislo2 = 6;
            int result = 2;
            string op = "/";
            bool expected = true;
            //Act
            bool actual = CalculatorChecker.validateCalculatordivisiontrue(chislo1, chislo2, op, result);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void validateCalculatordivisionfalse()
        {
            // Arrange
            int chislo1 = 12;
            int chislo2 = 4;
            int result = 2;
            string op = "/";
            bool expected = false;
            //Act
            bool actual = CalculatorChecker.validateCalculatordivisionfalse(chislo1, chislo2, op, result);
            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}