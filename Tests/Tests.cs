using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        private string testFolder = "Test Cases/";

        [TestMethod]
        public void ExecuteProgram()
        {
            BrainSharp.Interpreter.Main(new [] {testFolder + "Hello World.txt"});
        }
    }
}
