using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OutfitBuilder
{
    public class OutfitModel : ControlBase
    {
        public OutfitModel(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public bool WearingHankie 
        {
            get { return Driver.ElementDisplayed(Locators.Hankie); }
        }

        public bool WearingJacket
        {
            get { return Driver.ElementDisplayed(Locators.Jacket); }
        }

        public bool WearingTrousers
        {
            get { return Driver.ElementDisplayed(Locators.Trousers); }
        }

        public bool WearingNeckwear
        {
            get { return Driver.ElementDisplayed(Locators.Neckwear); }
        }

        public bool WearingWaistcoat
        {
            get { return Driver.ElementDisplayed(Locators.Waistcoat); }
        }

        public class Locators
        {
            public static By Container = By.Id("main-outfit");
            public static By BaseImage = By.Id("initial-image");
            public static By Hankie = By.Id("hankie-image");
            public static By Jacket = By.ClassName("img-responsive ob-image jacket");
            public static By Trousers = By.Id("img-responsive ob-image trousers");
            public static By Neckwear = By.Id("img-responsive ob-image neckwear");
            public static By Waistcoat = By.Id("img-responsive ob-image waistcoat");
        }
    }
}
