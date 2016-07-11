using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using TMLewinModel.Controls.OutfitBuilder.ClothingItems;

namespace TMLewinModel.Controls.OutfitBuilder.Catalogues
{
    public class AccessoriesCatalogue : ControlBase
    {
        public AccessoriesCatalogue(TestSettings testSettings) : base(testSettings)
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

        public IReadOnlyCollection<Accessory> Accessories
        {
            get
            {
                var elements = Container.FindElements(Locators.Accessories);
                return elements.Select(e => new Accessory(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public class Locators
        {
            public static By Container = By.Id("outfits");
            public static By TitleLabel = By.CssSelector("h2");
            public static By ToggleChildSizesCheckbox = By.Id("adultchild-toggle");
            public static By Accessories = By.CssSelector("[class='item accessory']");
        }
    }
}
