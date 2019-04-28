using System;
using Microsoft.AspNetCore.Mvc;
using HelloWorldManager;

namespace HelloWorldAPI.Controllers
{
    [Route("api/HelloWorld")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly IHelloWorldManager _helloWorldManager;
        public HelloWorldController(IHelloWorldManager helloWorldManager)
        {
            _helloWorldManager = helloWorldManager;
        }
        
        // GET api/HelloWorld
        [HttpGet]
        public ActionResult<string> Get()
        {
            return _helloWorldManager.GetHelloWorldMessage();
        }
       
    }
}
