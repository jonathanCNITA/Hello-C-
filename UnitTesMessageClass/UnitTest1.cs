using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace UnitTesMessageClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_morning()
        {
            FakeTime CustomTime = new FakeTime(new DateTime(2018, 08, 22, 09, 12, 00));
            Message target = new Message(CustomTime);
            string result = target.GetHelloMessage();
            Assert.AreEqual("Bonjour jonathan.courat", result);
        }

        [TestMethod]
        public void TestMethod_evenning()
        {
            FakeTime CustomTime = new FakeTime(new DateTime(2018, 08, 22, 19, 12, 00));
            Message target = new Message(CustomTime);
            string result = target.GetHelloMessage();
            Assert.AreEqual("Bonsoir jonathan.courat", result);
        }

        [TestMethod]
        public void TestMethod_weekend()
        {
            FakeTime CustomTime = new FakeTime(new DateTime(2018, 08, 25, 19, 12, 00));
            Message target = new Message(CustomTime);
            string result = target.GetHelloMessage();
            Assert.AreEqual("Bon weekend jonathan.courat", result);
        }
    }
}
