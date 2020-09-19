using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialJuanGianella.Controllers;

namespace ParcialJuanGianella.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGet()
        {
            //Arrange
            PaisController controller = new PaisController();
            //Act
            var listapais = controller.GetPais();
            //Assert
            Assert.IsNotNull(listapais);
        }
    }
}
