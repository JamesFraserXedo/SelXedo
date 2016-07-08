using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.HomePage
{
    public class HomePageFeature : ControlBase
    {
        private IWebElement _container;
        public HomePageFeature(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public IWebElement Image
        {
            get { return Driver.FindElement(_container, Locators.ImageElement); }
        }

        public IWebElement NameLabel
        {
            get { return Driver.FindElement(_container, Locators.NameLabel); }
        }

        public IWebElement DescriptionLabel
        {
            get { return Driver.FindElement(_container, Locators.DescriptionLabel); }
        }

        public Button Button
        {
            get { return new Button(Driver.FindElement(_container, Locators.Button)); }
        }

        public string Name
        {
            get { return NameLabel.Text; }
        }

        public string Description
        {
            get { return DescriptionLabel.Text; }
        }

        public class Locators
        {
            public static By ImageElement = By.CssSelector("img");
            public static By NameLabel = By.CssSelector("h2");
            public static By DescriptionLabel = By.CssSelector("p");
            public static By Button = By.CssSelector("[role='button']");
        }
    }
}
