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

        protected InputBox OrganizationNameInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.OrganisationNameInputbox)); }
        }

        protected InputBox CityInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.Address3Inputbox)); }
        }

        protected InputBox StateInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.Address4Inputbox)); }
        }

        protected InputBox ZipcodeInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.PostcodeInputbox)); }
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
