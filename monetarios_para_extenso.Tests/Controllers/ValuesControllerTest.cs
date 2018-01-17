using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual("Valor Inválido", result);
        }

        [TestMethod]
        public void TestConverteValoresDecimais()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Convert(33.34);

            // Assert
            Assert.IsNotNull(result);

            Assert.AreEqual("Valor Inválido", result);

        }

        [TestMethod]
        public void TestConverteValoresInvalidos()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            string result = controller.Convert(13.92);

            Assert.AreEqual("Valor Inválido", result);

            result = controller.Convert(-23.00);

            Assert.AreEqual("Valor Inválido", result);

            result = controller.Convert(1456);

            Assert.AreEqual("Valor Inválido", result);

        }

        [TestMethod]
        public void TestConverteValoresValidos()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Convert(33);

            // Assert
            Assert.IsNotNull(result);

            Assert.AreEqual("trinta e três reais", result);

            result = controller.Convert(45);

            Assert.AreEqual("quarenta e cinco reais", result);

            result = controller.Convert(42);

            Assert.AreEqual("quarenta e dois reais", result);

            result = controller.Convert(678);

            Assert.AreEqual("seiscentos e setenta e oito reais", result);
        }

    }
}
