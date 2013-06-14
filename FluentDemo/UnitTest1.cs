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

        [TestMethod]
        public void Null()
        {
            Assert.IsNotNull(null);
            Assert.IsNull(new Object());
            int? number = null;
            Assert.IsNotNull(number);
        }

        [TestMethod]
        public void Type()
        {
            Assert.IsInstanceOfType(new Object(), typeof(string));
        }

        [TestMethod]
        public void String()
        {
            var s = "";
            Assert.IsFalse(s == string.Empty);

            var sentence = "John kicked the ball";
            Assert.IsTrue(sentence.Contains("ball");
        }
    }
}
