﻿using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public class BaseCatalogue : ControlBase
    {
        public BaseCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement Header
        {
            get { return Driver.FindElement(Container, Locators.Header); }
        }

        public class Locators
        {
            public static readonly By Container = By.Id("catalogue-view");
            public static readonly By Header = By.CssSelector("h2");
        }
    }
}
