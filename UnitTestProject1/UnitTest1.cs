/****************************************************/
/* Author : Sreenavya N
 * Date : Feb 21, 2020
 * This project is a part of Call-Em-All coding challenge
 * A set of test cases for MaxDistance(char[]) method
 /**************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CallEmAll_Test;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // Validating happy case
        [TestMethod]
        public void TestMethod1() => Assert.AreEqual(24, Program.MaxDistance(new char[] { 'a', 'z' }));

        // Validating happy case
        [TestMethod]
        public void TestMethod2() => Assert.AreEqual(7, Program.MaxDistance(new char[] { 'g', 'b', 'c', 'j', 'b', 'd', 'h', 'a' }));

        // Validating when i < j AND a[i] doesn't occur before a[j] in alphabet
        [TestMethod]
        public void TestMethod4() => Assert.AreEqual(-1, Program.MaxDistance(new char[] { 'z', 'a' }));

        // Validating a single charecter input
        [TestMethod]
        public void TestMethod5() => Assert.AreEqual(-1, Program.MaxDistance(new char[] { 'a' }));

        // Validating null input will get an output of -1
        [TestMethod]
        public void TestMethod3() => Assert.AreEqual(-1, Program.MaxDistance(null));

        // Validating upper case alphabet is a valid input
        [TestMethod]
        public void TestMethod6() => Assert.AreEqual(24, Program.MaxDistance(new char[] { 'A' , 'Z' }));
        // Validating non-alphabet chaecters in the input will get an output of -1
        [TestMethod]
        public void TestMethod7() => Assert.AreEqual(-1, Program.MaxDistance(new char[] { '1' , '2', 'a', 'c' }));

        // Validating mixed case input
        [TestMethod]
        public void TestMethod8() => Assert.AreEqual(56, Program.MaxDistance(new char[] { 'A' , 'z' }));
    }
}
