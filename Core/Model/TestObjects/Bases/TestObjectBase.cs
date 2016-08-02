using OpenQA.Selenium;
using Core.Model.SupportTools;

namespace Core.Model.TestObjects.Bases
{
    public abstract class TestObjectBase
    {
        public TestSettings TestSettings;

        protected TestObjectBase(TestSettings testSettings)
        {
            TestSettings = testSettings;
        }

        public IWebDriver Driver
        {
            get { return TestSettings.Driver; }
        }
    }
}