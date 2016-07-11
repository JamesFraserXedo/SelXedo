using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OutfitBuilder.ClothingItems
{
    public class Accessory : ControlBase
    {
        private IWebElement _element;

        public Accessory(TestSettings testSettings, IWebElement element) : base(testSettings)
        {
            _element = element;
        }

        public IWebElement NameLabel
        {
            get { return Driver.FindElement(_element, Locators.NameLabel); }
        }
        
        public IWebElement Item
        {
            get { return Driver.FindElement(_element, Locators.Item); }
        }
        
        private IWebElement SelectedWrapper
        {
            get { return Driver.FindElement(_element, Locators.SelectedWrapper); }
        }

        public string Name
        {
            get { return NameLabel.Text; }
        }

        public bool Selected
        {
            get { return SelectedWrapper.GetAttribute("class").Contains("selected"); }
        }

        public void Select()
        {
            if (Selected)
            {
                return;
            }
            _element.Click();
        }

        public void Deselect()
        {
            if (!Selected)
            {
                return;
            }
            _element.Click();
        }

        public class Locators
        {
            public static By NameLabel = By.CssSelector(".item-text-link");
            public static By SelectedWrapper = By.CssSelector("span");
            public static By Item = By.CssSelector("[data-at='lnk-accessories']");
        }
    }
}
