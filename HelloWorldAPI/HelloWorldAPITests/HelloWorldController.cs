using System;
using Xunit;
using HelloWorldAPI.Controllers;
using Moq;
using HelloWorldManager;

namespace HelloWorldAPITests
{
    public class HelloWorldControllerTests
    {
        private readonly Mock<IHelloWorldManager> _helloWorldManager;
        private readonly HelloWorldController _controller;
        public HelloWorldControllerTests()
        {
            _helloWorldManager = new Mock<IHelloWorldManager>();
            _controller = new HelloWorldController(_helloWorldManager.Object);
        }

        [Fact]
        public void Controller_ReturnsHelloWorld()
        {
            //Arrange
            var message = "Hello World";
            _helloWorldManager.Setup(f => f.GetHelloWorldMessage()).Returns(message);

            //Act
            var result = _controller.Get();

            //Assert
            Assert.Equal(message, result.Value.ToString());
        }
    }
}
