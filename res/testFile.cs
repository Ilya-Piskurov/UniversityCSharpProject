using Microsoft.VisualStudio.TestTools.UnitTesting;
using TSPP_ShoesSolution.source.model;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthTest()
        {
            Assert.IsTrue(AuthManager.Authorization('admin', 'admin'));
        }

        public void ShoesManagerSearchByArticle()
        {
            Assert.AreEqual('Name = Sandal Gucchi, Article = M1111, Count = 5, Price = 1200', ShoesManager.ReadRecordInDB("M1111"));
        }
    }
}