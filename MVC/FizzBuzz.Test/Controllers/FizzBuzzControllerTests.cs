using FizzBuzz.Controllers;
using FizzBuzz.Models;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FizzBuzz.Test.Controllers
{
    public class FizzBuzzControllerTests
    {
        private Mock<IFizzBuzzService> mockService;
        
       
        [Fact]
        public void WhetherModelsUpdateWithExpectedFizzBuzzNumber()
        {
            //Arrange

            this.mockService = new Mock<IFizzBuzzService>();
            this.mockService.Setup(x=>x.GetFizzBuzzNumbers(It.IsAny<int>())).Returns(new
                List<string> { "1", "2", "Fizz", "4", "Buzz" });
            var controller = new FizzBuzzController(this.mockService.Object);

            //Act 

            var result = controller.Display(new FizzbuzzViewModel { Input = 5 });

            //Assert

            ViewResult output = result as ViewResult;            
            Assert.Equal(output.ViewName, "Display");
            var modeldata = output.Model;

            Assert.Equal(modeldata, new List<string>{ "1", "2", "Fizz", "4", "Buzz" });
            this.mockService.Verify(x => x.GetFizzBuzzNumbers(It.IsAny<int>()), Times.Once);
        }
    }
}
