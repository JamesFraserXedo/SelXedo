using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public abstract class NonNeckwearBase : ClothingBase
    {
        protected NonNeckwearBase(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        protected IWebElement DetailsElement
        {
            get { return Driver.FindElement(_container, Locators.Details); }
        }

        public override string Name
        {
            get { return Driver.FindElement(_container, Locators.NameLabel).Text; }
        }

        public override string Id
        {
            get { return DetailsElement.GetAttribute("id"); }
        }

        public override bool Selected
        {
            get { return Driver.FindElement(_container, Locators.Selected).GetAttribute("class").Contains("selected"); }
        }

        public string ImagePath
        {
            get { return DetailsElement.GetAttribute("data-preview"); }
        }

        public override void Select()
        {
            var count = 0;
            //TODO check why it needs this loop - looks like a wait also fixes it
            while (!Selected && count < 10)
            {   
                count++;
                Driver.FindElement(_container, Locators.Selected).Click();
            }
        }

        public override void Deselect()
        {
            if (Selected)
            {
                _container.Click();
            }
        }

        protected class Locators
        {
            public static readonly By NameLabel = By.CssSelector("[class='item-text-link']");
            public static readonly By Selected = By.CssSelector("span");
            public static readonly By Details = By.CssSelector("a");
        }
    }
}
