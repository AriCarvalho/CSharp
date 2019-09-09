using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Mock
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var obj = new Mock<IObj>();
            obj.Setup((x) => x.Func("doze")).Returns(12);

            var o = obj.Object;

            Assert.AreEqual(12,o.Func("doze"));

        }
    }

    public interface IObj
    {
        int Func(string str);
    }
}
