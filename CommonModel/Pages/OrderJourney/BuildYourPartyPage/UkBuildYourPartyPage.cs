using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.Controls.OrderJourney.BuildYourParty;
using CommonModel.Controls.OrderJourney.BuildYourParty.OutfitWearersPanel;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages.OrderJourney.BuildYourPartyPage
{
    public abstract class UkBuildYourPartyPage : BaseBuildYourPartyPage
    {
        protected UkBuildYourPartyPage(TestSettings testSettings) : base(testSettings)
        {
        }

        protected IWebElement TotalOrderValueLabel
        {
            get { return Driver.FindElement(Locators.TotalOrderValueLabel); }
        }

        public string TotalOrderValue
        {
            get { return TotalOrderValueLabel.Text; }
        }

        public ReadOnlyCollection<UkWearersPanel> WearerPanels
        {
            get{ return OutfitWearerPanelElements.Select(element => new UkWearersPanel(TestSettings, element)).ToList().AsReadOnly(); }
        }

        public new class Locators : BaseBuildYourPartyPage.Locators
        {
            public static readonly By TotalOrderValueLabel = By.ClassName("build-party-total-amount");
        }
    }
}
