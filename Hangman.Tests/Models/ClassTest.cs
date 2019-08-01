using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;

namespace Hangman.Tests
{
    [TestClass]
    public class ClassNameTest
    {
        [TestMethod]
        public void MethodName_Spec_ExpectedOutput()
        {
            ClassName instanceName = new ClassName();
            Assert.AreEqual(ExpectedOutput, instanceName.MethodName(inputHere));
        }
    }
}