using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VariablesExample
{
    [TestClass]
    public class Variables
    {
        [TestMethod]
        public void Declaration()
        {
            // This line contains a syntax error.
            // It prevents the solution from building,
            // so it will not pass.
            Console.WriteLine("Hello World");



            // Once the above error is fixed, and the
            // project builds, this line contains a
            // logical error - it "asserts" that a condition
            // is true, but the condition is false,
            // so the test will not pass.
            Assert.IsTrue(1 == 1);
        }

    }
}
