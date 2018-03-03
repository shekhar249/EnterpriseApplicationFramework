using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp;

namespace TestMyApp
{
    [TestClass]
    public class UnitTest1
    {
        MyApplication app;

        [TestInitialize]
        public void Initialize()
        {
            app = new MyApplication();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int result=app.Add(100,23);

            Assert.IsTrue(result==123,"Additionn is not working");
        }
    }
}
