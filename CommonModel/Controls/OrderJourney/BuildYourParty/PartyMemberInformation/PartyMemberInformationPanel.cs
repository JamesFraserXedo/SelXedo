using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.BuildYourParty.PartyMemberInformation
{
    public class PartyMemberInformationPanel : ControlBase
    {
        public PartyMemberInformationPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public MemberDetailsForm MemberDetailsForm
        {
            get { return new MemberDetailsForm(TestSettings); }
        }

        public MemberSizesForm MemberSizesForm
        {
            get { return new MemberSizesForm(TestSettings); }
        }

        public Button SubmitDetailsButton
        {
            get { return new Button(Driver.FindElement(Locators.SubmitDetailsButton)); }
        }

        public Button CancelButton
        {
            get { return new Button(Driver.FindElement(Locators.CancelButton)); }
        }

        public class Locators
        {
            public static readonly By SubmitDetailsButton = By.CssSelector("[data-at='btn-submit-party-member']");
            public static readonly By CancelButton = By.CssSelector("[class='mfp-close']");
        }
    }
}
