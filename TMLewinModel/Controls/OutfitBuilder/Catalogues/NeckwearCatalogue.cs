using System.Collections.Generic;
using System.Linq;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using TMLewinModel.Controls.OutfitBuilder.ClothingItems;

namespace TMLewinModel.Controls.OutfitBuilder.Catalogues
{
    public class NeckwearCatalogue : ControlBase
    {
        public NeckwearCatalogue(TestSettings testSettings)
            : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement TitleLabel
        {
            get { return Driver.FindElement(Container, Locators.TitleLabel); }
        }

        public Checkbox ToggleChildSizesCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Container, Locators.ToggleChildSizesCheckbox)); }
        }

        public Button ShowTiesButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ShowTiesButton)); }
        }

        public IWebElement TiesNumberLabel
        {
            get { return Driver.FindElement(Container, Locators.TiesNumberLabel); }
        }

        public Button ShowRuchesButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ShowRuchesButton)); }
        }

        public IWebElement RuchesNumberLabel
        {
            get { return Driver.FindElement(Container, Locators.RuchesNumberLabel); }
        }

        public IReadOnlyCollection<Neckwear> Neckwears
        {
            get
            {
                var elements = Container.FindElements(Locators.Neckwears);
                return elements.Select(e => new Neckwear(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public class Locators
        {
            public static By Container = By.Id("outfits");
            public static By TitleLabel = By.CssSelector("h2");
            public static By ToggleChildSizesCheckbox = By.Id("adultchild-toggle");
            public static By ShowTiesButton = By.CssSelector("[data-producttype='2']");
            public static By TiesNumberLabel = By.CssSelector("[data-producttype='2']>p>span");
            public static By ShowRuchesButton = By.CssSelector("[data-producttype='1']");
            public static By RuchesNumberLabel = By.CssSelector("[data-producttype='1']>p>span");
            public static By Neckwears = By.CssSelector("[data-at='lnk-neckwear']");
        }
    }
}
