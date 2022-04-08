using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzzLib;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.UnitTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void DivideBy_3_or_5_ReturnsInvalidItem_emptyInput()
        {
            
            //Arrange
            FizzBuzzLib.FizzBuzz obj = new FizzBuzzLib.FizzBuzz();
            List<String> expected = new List<String>();
            expected.Add("Invalid item");
            //Act
            List<String> result = new List<string>();
            foreach (var item in obj.Multipleof_3_or_5(""))
                result.Add(item);


            //Assert
            Assert.IsTrue(expected.SequenceEqual(result));
        }
        [TestMethod]
        public void DivideBy_3_or_5_ReturnsInvalidItem_input_A()
        {

            //Arrange
            FizzBuzzLib.FizzBuzz obj = new FizzBuzzLib.FizzBuzz();
            List<String> expected = new List<String>();
            expected.Add("Invalid item");
            //Act
            List<String> result = new List<string>();
            foreach (var item in obj.Multipleof_3_or_5("A"))
                result.Add(item);


            //Assert
            Assert.IsTrue(expected.SequenceEqual(result));
        }
        [TestMethod]
        public void DivideBy_3_or_5_ReturnsDivideOnly_By_3()
        {

            //Arrange
            FizzBuzzLib.FizzBuzz obj = new FizzBuzzLib.FizzBuzz();
            List<String> expected = new List<String>();
            expected.Add("Fizz");
            //Act
            List<String> result = new List<string>();
            foreach (var item in obj.Multipleof_3_or_5("3"))
                result.Add(item);


            //Assert
            Assert.IsTrue(expected.SequenceEqual(result));
        }
        [TestMethod]
        public void DivideBy_3_or_5_ReturnsDivideOnly_By_5()
        {

            //Arrange
            FizzBuzzLib.FizzBuzz obj = new FizzBuzzLib.FizzBuzz();
            List<String> expected = new List<String>();
            expected.Add("Buzz");
            //Act
            List<String> result = new List<string>();
            foreach (var item in obj.Multipleof_3_or_5("5"))
                result.Add(item);


            //Assert
            Assert.IsTrue(expected.SequenceEqual(result));
        }
        [TestMethod]
        public void DivideBy_3_or_5_ReturnsDivideOnly_By_15()
        {

            //Arrange
            FizzBuzzLib.FizzBuzz obj = new FizzBuzzLib.FizzBuzz();
            List<String> expected = new List<String>();
            expected.Add("FizzBuzz");
            //Act
            List<String> result = new List<string>();
            foreach (var item in obj.Multipleof_3_or_5("15"))
                result.Add(item);


            //Assert
            Assert.IsTrue(expected.SequenceEqual(result));
        }
        [TestMethod]
        public void DivideBy_3_or_5_ReturnsDivideOnly_By_1()
        {

            //Arrange
            FizzBuzzLib.FizzBuzz obj = new FizzBuzzLib.FizzBuzz();
            List<String> expected = new List<String>();
            expected.Add("Divided 1 by 3");
            expected.Add("Divided 1 by 5");
            //Act
            List<String> result = new List<string>();
            foreach (var item in obj.Multipleof_3_or_5("1"))
                result.Add(item);


            //Assert
            Assert.IsTrue(expected.SequenceEqual(result));
        }
        [TestMethod]
        public void DivideBy_3_or_5_ReturnsDivideOnly_By_23()
        {

            //Arrange
            FizzBuzzLib.FizzBuzz obj = new FizzBuzzLib.FizzBuzz();
            List<String> expected = new List<String>();
            expected.Add("Divided 23 by 3");
            expected.Add("Divided 23 by 5");
            //Act
            List<String> result = new List<string>();
            foreach (var item in obj.Multipleof_3_or_5("23"))
                result.Add(item);


            //Assert
            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}
