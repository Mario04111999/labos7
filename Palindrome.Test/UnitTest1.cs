using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
//using ProvjeraPalindroma;

namespace Palindrome.Test
{
    [TestFixture]

    public class UnitTest1
    {
        ProvjeraPalindroma Palindrom = new ProvjeraPalindroma();

        [TestCase("idu ljudi")]
        [TestCase("ana")]
        [TestCase("evolove")]
        [TestCase("ANA VOLI MILOVANA")]
        [TestCase("esineženise")]
        [TestCase("nitko nije lu da spava")]

        //Provjera je li napisan palindrom
        public void TestMethod1(string input)
        {
            bool expected = true;
            bool actual = Palindrom.Palindrome_Check(input);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }


        [TestCase("Sensas team je najbolji")]
        [TestCase("nitko nije savršen")]
        [TestCase("netko mi je ukrao auto")]

        //Provjera kada nije napisan palindrom
        public void TestMethod2(string input)
        {
            bool expected = false;
            bool actual = Palindrom.Palindrome_Check(input);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }
        
        
       
        [TestCase()]
        [TestCase(" ")]
        //Provjera kad nije ništa napisano 
        public void TestMethod3(string input)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<ArgumentException>(() => Palindrom.Palindrome_Check(input));
        }
    }
}