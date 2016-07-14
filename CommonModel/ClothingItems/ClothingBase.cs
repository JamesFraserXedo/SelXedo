using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public abstract class ClothingBase : ControlBase
    {
        protected IWebElement _container;
        protected ClothingBase(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        protected IWebElement DetailsElement
        {
            get { return Driver.FindElement(_container, Locators.Details); }
        }

        public string Name
        {
            get { return Driver.FindElement(_container, Locators.NameLabel).Text; }
        }

        public string Id
        {
            get { return DetailsElement.GetAttribute("id"); }
        }

        public bool Selected
        {
            get { return Driver.FindElement(_container, Locators.Selected).GetAttribute("class").Contains("selected"); }
        }

        public string ImagePath
        {
            get { return DetailsElement.GetAttribute("data-preview"); }
        }

        public void Select()
        {
            if (!Selected)
            {
                _container.Click();
            }
        }

        public void Deselect()
        {
            if (Selected)
            {
                _container.Click();
            }
        }

        protected class Locators
        {
            public static By NameLabel = By.ClassName("item-text-link");
            public static By Selected = By.CssSelector("span");
            public static By Details = By.CssSelector("a");
        }
    }
}
