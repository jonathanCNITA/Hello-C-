using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace UnitTesMessageClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Message target = new Message();
            string result = target.GetHelloMessage();
            Assert.AreEqual("Bonjour jonathan.courat", result);
        }
    }
}
