using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.CollectionsPage
{
    public class CollectionProductDetails : ControlBase
    {
        public CollectionProductDetails(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement ImageElement
        {
            get { return Driver.FindElement(Container, Locators.Image); }
        }

        private IWebElement NameLabel
        {
            get { return Driver.FindElement(Container, Locators.NameLabel); }
        }

        private IWebElement DescriptionLabel
        {
            get { return Driver.FindElement(Container, Locators.DescriptionLabel); }
        }

        private IWebElement PriceLabel
        {
            get { return Driver.FindElement(Container, Locators.PriceLabel); }
        }

        public Button OrderTryOnButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.OrderTryOnButton)); }
        }

        public Button AddToOrderButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.AddToOrderButton)); }
        }

        public Button DismissButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.DismissButton)); }
        }

        public string ImageSource
        {
            get { return ImageElement.GetAttribute("src"); }
        }

        public string Name
        {
            get { return NameLabel.Text; }
        }

        public string Description
        {
            get { return DescriptionLabel.Text; }
        }

        public string Price
        {
            get { return PriceLabel.Text; }
        }

        public class Locators
        {
            public static readonly By Container = By.CssSelector("[id='hp-product-details-popup']");
            public static readonly By Image = By.CssSelector("[class='product-image']");
            public static readonly By NameLabel = By.CssSelector("[class='product-name']");
            public static readonly By DescriptionLabel = By.CssSelector("[class='product-description']");
            public static readonly By PriceLabel = By.CssSelector("[class='product-price-amount']");
            public static readonly By OrderTryOnButton = By.CssSelector("[class='button primary-cta tryon-link']");
            public static readonly By AddToOrderButton = By.CssSelector("[class='button secondary-cta addtoorder-link']");
            public static readonly By DismissButton = By.CssSelector("[class='mfp-close']");
        }
    }
}
