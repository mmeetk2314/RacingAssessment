using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingAssessment;

namespace RacingUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRandom()
        {
            //instantiate a new form
            Form1 myForm = new Form1 ();
            //run the method on the form and then pass the result to a variable for testing
            var randNum = myForm.RandomGenerator();
            //is the random number generator working?
            Assert.IsTrue((randNum.Next(1,5) > 0) && (randNum.Next(1,5) < 6));
        }

        [TestMethod]
        public void TestStartingPoint()
        {
            //instantiate a new form
            Form1 myForm = new Form1();
            //run the method on the form and then pass the starting point to a variable for testing
            var StartingPoint = myForm.StartingPoint();
            //is the starting point what it should be?
            Assert.IsTrue(StartingPoint == 10);
        }
    }
}
