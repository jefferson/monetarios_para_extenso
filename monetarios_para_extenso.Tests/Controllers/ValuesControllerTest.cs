using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using monetarios_para_extenso;
using monetarios_para_extenso.Controllers;

namespace monetarios_para_extenso.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void ConverteValoresNegativos()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Convert(-1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Valor Inválido", result.ElementAt(0));
        }

        [TestMethod]
        public void ConverteValoresDecimais()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Convert(33.34);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Valor Inválido", result);

        }




    }
}
