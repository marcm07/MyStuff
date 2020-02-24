using NUnit.Framework;
using Problems;
using System;
using TestCaseData;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public static void Test1()
        {
            //ARANGE
            
            //ACT
            string ans1 = Program.Prefix("Hello");
            string ans2 = Program.Prefix("");
            string ans3 = Program.Prefix("what    ...  did you say?? ");
            //ASSERT
            Assert.That(ans1, Is.EqualTo("5,1:Hello"));
            Assert.That(ans2, Is.EqualTo("null"));
            Assert.That(ans3, Is.EqualTo("27,5:what    ...  did you say?? "));
        }
    }
    /*public class MyDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("Hello")
            }
        }
    }*/
}