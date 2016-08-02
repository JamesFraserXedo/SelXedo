using OpenQA.Selenium;
using Core.Model.SupportTools;

namespace Core.Model.TestObjects.Bases
{
    public class TestSettings
    {
        public IWebDriver Driver;

        public TestSettings(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
