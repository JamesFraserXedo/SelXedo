using CommonModel.Controls.Billing;
using Core.CustomElements;
using Core.Model.TestObjects.Bases;

namespace XedoModel.Controls.OrderJourney
{
    public class BillingAddressPanel : NotPgOrderBillingAddressPanel
    {
        public BillingAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        protected Inputbox OrganizationNameInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.OrganisationNameInputbox)); }
        }

        protected Inputbox CityInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.Address3Inputbox)); }
        }

        protected Inputbox StateInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.Address4Inputbox)); }
        }

        protected Inputbox ZipcodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.PostcodeInputbox)); }
        }

        public string OrganizationName
        {
            get { return OrganizationNameInputbox.Text; }
            set { OrganizationNameInputbox.SendKeys(value); }
        }

        public string City
        {
            get { return CityInputbox.Text; }
            set { CityInputbox.SendKeys(value); }
        }

        public string State
        {
            get { return StateInputbox.Text; }
            set { StateInputbox.SendKeys(value); }
        }

        public string Zipcode
        {
            get { return ZipcodeInputbox.Text; }
            set { ZipcodeInputbox.SendKeys(value); }
        }
    }
}
