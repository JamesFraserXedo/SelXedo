using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using CommonModel.Controls.CollectionsPage;
using CommonModel.Controls.HomePage.ColourMatch;
using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Pages
{
    public class HomePage: PageBase
    {
        public HomePage(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public override bool IsLoaded()
        {
            return Collections.Any();
        }

        public Button LetsGetStartedButton
        {
            get { return new Button(Driver.FindElement(Locators.LetsGetStartedButton)); }
        }

        public Button HowItWorksGetStartedButton
        {
            get { return new Button(Driver.FindElement(Locators.HowItWorksGetStartedButton)); }
        }

        public UsColourMatch ColourMatch
        {
            get { return new UsColourMatch(TestSettings); }
        }

        public Button PerfectMatchGetStartedButton
        {
            get { return new Button(Driver.FindElement(Locators.PerfectMatchGetStartedButton)); }
        }

        public ReadOnlyCollection<Collection> Collections
        {
            get
            {
                return
                    Driver.FindElements(Locators.Collections)
                        .Select(e => new Collection(TestSettings, e))
                        .ToList()
                        .AsReadOnly();
            }
        }

        public class Locators
        {
            public static readonly By LetsGetStartedButton = By.CssSelector("[class='overlay']>a");
            public static readonly By HowItWorksGetStartedButton = By.CssSelector("[class='row hp-how-It-Works']>div>a");
            public static readonly By Collections = By.CssSelector("[class='inspire-item collection-single']");
            public static readonly By PerfectMatchGetStartedButton = By.CssSelector("[class='row hp-perfect-match']>div>a");
        }
    }
}
