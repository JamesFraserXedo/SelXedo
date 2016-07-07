using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.HomePage
{
    public class HowItWorksPanel : ControlBase
    {
        public HowItWorksPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement Title
        {
            get { return Driver.FindElement(Container, Locators.Title); }
        }

        public Button GetStartedButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.GetStartedButton)); }
        }

    public class Locators
        {
            public static By Container = By.Id("hp-how-It-Works");
            public static By Title = By.CssSelector("h2");
        public static By GetStartedButton = By.CssSelector("[data-galabel='How-It-Works-CTA-clicked']");
        }
    }
}
