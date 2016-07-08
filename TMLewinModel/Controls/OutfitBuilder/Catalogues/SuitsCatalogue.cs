using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OutfitBuilder.Catalogues
{
    public class SuitsCatalogue : ControlBase
    {
        public SuitsCatalogue(TestSettings testSettings) : base(testSettings)
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

        public class Locators
        {
            public static By Container = By.Id("outfits");
            public static By TitleLabel = By.CssSelector("h2");
            public static By ToggleChildSizesCheckbox = By.Id("adultchild-toggle");
            public static By Suits = By.CssSelector("[class='item suit']");
        }
    }
}
