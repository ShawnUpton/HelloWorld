using NUnit.Framework;
using Microsoft.Extensions.Logging;
using HelloWorld.WebAPI.Controllers;
using Microsoft.Extensions.Options;
namespace HelloWorld.WebAPI.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IOptions<AppSettingsModel> settings;
            settings = null;
            var controller = new HelloWorldAPI(settings);
          
            var response = controller.Get();
    
            Assert.AreEqual("Hello World", response);
        }
    }
}