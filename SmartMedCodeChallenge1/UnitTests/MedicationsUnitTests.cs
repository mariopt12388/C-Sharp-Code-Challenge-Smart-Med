using SmartMedCodeChallenge1.Controllers;
using System.Threading.Tasks;
using Xunit;

namespace SmartMedCodeChallenge1.UnitTests
{
    public class MedicationsUnitTests
    {
        ValuesController valuesController = new ValuesController();

        [Fact]
        public void Get()
        {
            //Arrange
            var expectedResponse = "No data found";
            var response = valuesController.Get(-1);

            

            //Assert
            Assert.Matches(expectedResponse, response);
        }

        [Fact]
        public void Post()
        {
            //Arrange
            var expectedResponse = "Record inserted with the name as " + "test" + ", the quantity as " + 1 + " and the creation date as " + "2022-12-12 12:12:12";
            var response = valuesController.Post("test", 1, "2022-12-12 12:12:12");





            //Assert
            Assert.Matches(expectedResponse, response);
        }

        [Fact]
        public void PUT()
        {
            //Arrange
            var expectedResponse = "Record updated with the name as " + "test" + ", the quantity as " + 1 + " and the creation date as " + "2022-12-12 12:12:12" + " and the id as " + 1;
            var response = valuesController.Put(1, "test", 1, "2022-12-12 12:12:12");





            //Assert
            Assert.Matches(expectedResponse, response);
        }

        [Fact]
        public void DELETE()
        {
            //Arrange
            var expectedResponse = "Record deleted with the  id as " + 1;
            var response = valuesController.Delete(1);





            //Assert
            Assert.Matches(expectedResponse, response);
        }
    }
}