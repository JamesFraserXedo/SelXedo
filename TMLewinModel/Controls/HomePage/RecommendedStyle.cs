using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.HomePage
{
    public class RecommendedStyle : ControlBase
    {
        private IWebElement _container;

        public RecommendedStyle(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public IWebElement Image
        {
            get { return Driver.FindElement(_container, Locators.ImageElement); }
        }

        public IWebElement NameLabel
        {
            get { return Driver.FindElement(_container, Locators.NameLabel); }
        }
        
        public Button Button
        {
            get { return new Button(Driver.FindElement(_container, Locators.Button)); }
        }

        public string Name
        {
            get { return NameLabel.Text; }
        }

        public class Locators
        {
            public static readonly By ImageElement = By.CssSelector("img");
            public static readonly By NameLabel = By.CssSelector("p");
            public static readonly By Button = By.CssSelector("[role='button']");
        }
    }
}
