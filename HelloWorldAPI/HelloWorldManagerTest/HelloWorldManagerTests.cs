using System;
using Xunit;
using HelloWorldManager;

namespace HelloWorldManagerTest
{
    public class HelloWorldManagerTests
    {
        private IHelloWorldManager _manager;

        public HelloWorldManagerTests()
        {
            _manager = new HelloWorldManager.HelloWorldManager(); 
        }

        [Fact]
        public void HelloWorldManager_ReturnsCorrectMessage()
        {
            //Arrange
            //Act
            var message = _manager.GetHelloWorldMessage();

            //Assert
            Assert.Equal("Hello World", message);
        }
    }
}
