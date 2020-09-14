using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Business;
using HelloWorld.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HelloWorld.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldAPI : ControllerBase
    {
        private IOptions<AppSettingsModel> settings;

          public HelloWorldAPI(IOptions<AppSettingsModel> settings)
        {
            this.settings = settings;
        }    

        [HttpGet]
        public string Get()
        {
            HelloWorldLogic helloWorldLogic;
            if (settings?.Value?.ConnectionString == null)
            {
                helloWorldLogic = new HelloWorldLogic();
            }
            else
            {
                helloWorldLogic = new HelloWorldLogic(settings.Value.ConnectionString);
            }
            
            return helloWorldLogic.GetGreeting();            
        }
    }
}
