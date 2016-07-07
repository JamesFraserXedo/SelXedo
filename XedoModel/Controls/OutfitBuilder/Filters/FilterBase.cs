using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace Core.Controls.OutfitBuilder.Filters
{
    public abstract class FilterBase : ControlBase
    {
        protected FilterBase(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement HeadingContainer
        {
            get { return Driver.FindElement(Container, Locators.HeadingContainer); }
        }

        public IWebElement BodyContainer
        {
            get { return Driver.FindElement(Container, Locators.BodyContainer); }
        }

        public bool Expanded
        {
            get { return Driver.ElementDisplayed(Container, Locators.BodyContainer); }
        }

        public bool Completed
        {
            get { return HeadingContainer.GetAttribute("class").EndsWith("complete"); }
        }

        public void SetActive()
        {
            HeadingContainer.Click();
        }

        public class Locators
        {
            public static By HeadingContainer = By.XPath("./header");
            public static By BodyContainer = By.XPath("./nav");
            public static By Container { get; internal set; }
        }
    }
}