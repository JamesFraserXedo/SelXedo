using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.Collections
{
    public class CollectionOutfit : ControlBase
    {
        private IWebElement _container;

        public CollectionOutfit(TestSettings testSettings, IWebElement container)
            : base(testSettings)
        {
            _container = container;
        }

        public IWebElement NameLabel
        {
            get { return Driver.FindElement(_container, Locators.NameLabel); }
        }

        public IWebElement DetailsLabel
        {
            get { return Driver.FindElement(_container, Locators.DetailsLabel); }
        }

        public string Name
        {
            get { return Utils.StripBreaks(NameLabel.Text); }
        }

        public string Price
        {
            get { return DetailsLabel.Text.Substring(DetailsLabel.Text.LastIndexOf('$')); }
        }

        public void Select()
        {
            NameLabel.Click();
        }

        public class Locators
        {
            public static readonly By NameLabel = By.CssSelector("p");
            public static readonly By DetailsLabel = By.CssSelector("[class='inspire-item-detail']");
        }
    }
}
