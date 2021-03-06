﻿using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Neckwear
{
    public abstract class BaseNeckwearFilter : BaseExpandableFilter
    {
        protected BaseNeckwearFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public override IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public ColourSelector ColourBlack
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBlack)); }
        }

        public ColourSelector ColourBrown
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBrown)); }
        }

        public ColourSelector ColourRed
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourRed)); }
        }

        public ColourSelector ColourOrange
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourOrange)); }
        }

        public ColourSelector ColourCream
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourCream)); }
        }

        public ColourSelector ColourYellow
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourYellow)); }
        }

        public ColourSelector ColourGreen
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourGreen)); }
        }

        public ColourSelector ColourBlue
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBlue)); }
        }

        public ColourSelector ColourPurple
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourPurple)); }
        }

        public ColourSelector ColourPink
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourPink)); }
        }
        
        public Selector TieSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.TieSelect)); }
        }

        public new class Locators : BaseExpandableFilter.Locators
        {
            public static readonly By Container = By.Id("filters-neckwear");
            public static readonly By ColourBlack = By.CssSelector("[data-colour-desc='Black']");
            public static readonly By ColourBrown = By.CssSelector("[data-colour-desc='Brown']");
            public static readonly By ColourRed = By.CssSelector("[data-colour-desc='Red']");
            public static readonly By ColourOrange = By.CssSelector("[data-colour-desc='Orange']");
            public static readonly By ColourCream = By.CssSelector("[data-colour-desc='Cream']");
            public static readonly By ColourYellow = By.CssSelector("[data-colour-desc='Yellow']");
            public static readonly By ColourGreen = By.CssSelector("[data-colour-desc='Green']");
            public static readonly By ColourBlue = By.CssSelector("[data-colour-desc='Blue']");
            public static readonly By ColourPurple = By.CssSelector("[data-colour-desc='Purple']");
            public static readonly By ColourPink = By.CssSelector("[data-colour-desc='Pink']");

            public static readonly By TieSelect = By.CssSelector("[data-neckwear-typeid='2']");
        }
    }
}
