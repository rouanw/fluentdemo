using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentDemo
{
    // Docs: http://fluentassertions.codeplex.com/documentation

    [TestClass]
    public class FluentDemoTests
    {
        [TestMethod]
        public void TrueFalse()
        {
            Assert.IsTrue(true);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Reasons()
        {
            Assert.IsTrue(true, "That's just the way it is");
            Assert.IsFalse(false, "That's just the way it is");
        }
    }
}
