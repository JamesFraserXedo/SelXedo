using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.PriceListPage
{
    public class PriceListItem : ControlBase
    {
        private IWebElement _container;

        public PriceListItem(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public IWebElement TitleAndDescriptionLabel
        {
            get { return Driver.FindElement(_container, Locators.TitleAndDescriptionLabel); }
        }

        public IWebElement DescriptionLabel
        {
            get { return Driver.FindElement(_container, Locators.DescriptionLabel); }
        }

        public ReadOnlyCollection<IWebElement> ColourLabels
        {
            get { return _container.FindElements(Locators.ColourLabels); }
        }

        public ReadOnlyCollection<IWebElement> PriceLabels
        {
            get { return _container.FindElements(Locators.PriceLabels); }
        }

        public string Title
        {
            get { return TitleAndDescriptionLabel.Text.Split(new[] {"\n", "\r\n"}, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault(); }
        }

        public string Description
        {
            get { return DescriptionLabel.Text; }
        }

        public ReadOnlyCollection<string> Colours
        {
            get
            {
                var colourLabels = ColourLabels;
                return colourLabels.Select(e => e.GetCssValue("background-color")).ToList().AsReadOnly();
            }
        }

        public ReadOnlyCollection<string> Prices
        {
            get
            {
                var colourLabels = ColourLabels;
                return colourLabels.Select(e => e.Text).ToList().AsReadOnly();
            }
        }

        public class Locators
        {
            public static By TitleAndDescriptionLabel = By.ClassName("pricelist-suit-title");
            public static By DescriptionLabel = By.CssSelector("[class='pricelist-suit-title']>span");
            public static By ColourLabels = By.ClassName("colour-block");
            public static By PriceLabels = By.ClassName("price-detail");
        }
    }
}
