using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.CollectionsPage
{
    public class Collection : ControlBase
    {
        private IWebElement _container;
        public Collection(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        private IWebElement Details
        {
            get { return Driver.FindElement(_container, Locators.Details); }
        }

        private IWebElement ImageElement
        {
            get { return Driver.FindElement(_container, Locators.Image); }
        }

        public string Name
        {
            get { return Details.GetAttribute("data-tryon-productname"); }
        }

        public string Price
        {
            get { return Details.GetAttribute("data-tryon-price"); }
        }

        public string ImageSource
        {
            get { return ImageElement.GetAttribute("src"); }
        }

        public void Select()
        {
            _container.Click();
        }

        public class Locators
        {
            public static readonly By Details = By.CssSelector("a");
            public static readonly By Image = By.CssSelector("img");
        }
    }
}
