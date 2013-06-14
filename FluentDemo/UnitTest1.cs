using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FluentDemo
{
    // Docs: http://fluentassertions.codeplex.com/documentation

    [TestClass]
    public class FluentDemoTests
    {
        [TestMethod]
        public void TrueFalse()
        {
            Assert.IsTrue(false);
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void Reasons()
        {
            Assert.IsTrue(false, "That's just the way it is");
            Assert.IsFalse(true, "That's just the way it is");
        }

        [TestMethod]
        public void Equal()
        {
            Assert.AreEqual(6, 5);
        }

        [TestMethod]
        public void Contains()
        {
            var list = new List<string>{ "dog", "cat", "fish", "horse" };
            Assert.IsTrue(list.Contains("rabbit"));
        }
    }
}
