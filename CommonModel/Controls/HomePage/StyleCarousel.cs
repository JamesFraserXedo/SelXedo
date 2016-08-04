using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.HomePage
{
    public class StyleCarousel : ControlBase
    {
        //TODO
        public StyleCarousel(TestSettings testSettings) : base(testSettings)
        {
        }

        public class Locators
        {
            public static readonly By Container = By.CssSelector("[class='owl-suggested-styles-wrap']");
        }
    }
}
