﻿using System;
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
    public class WaistcoatsCatalogue : ControlBase
    {
        public WaistcoatsCatalogue(TestSettings testSettings) : base(testSettings)
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

        public IReadOnlyCollection<Waistcoat> MatchingWaistcoats
        {
            get
            {
                var elements = Container.FindElements(Locators.MatchingWaistcoats);
                return elements.Select(e => new Waistcoat(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<Waistcoat> OtherWaistcoats
        {
            get
            {
                var elements = Container.FindElements(Locators.OtherWaistcoats);
                return elements.Select(e => new Waistcoat(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<Waistcoat> AllWaistcoats
        {
            get
            {
                var elements = Container.FindElements(Locators.AllWaistcoats);
                return elements.Select(e => new Waistcoat(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public class Locators
        {
            public static By Container = By.Id("outfits");
            public static By TitleLabel = By.CssSelector("h2");
            public static By ToggleChildSizesCheckbox = By.Id("adultchild-toggle");
            public static By AllWaistcoats = By.CssSelector("[class='item waistcoat']");
            public static By MatchingWaistcoats = By.CssSelector("[class='matching-waistcoat-neckwear shown']>div>div");
            public static By OtherWaistcoats = By.CssSelector("[class='item-container all-waistcoats mobile-container-selector']>div");
        }
    }
}