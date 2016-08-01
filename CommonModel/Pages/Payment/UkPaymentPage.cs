using Core.CustomElements;
using Core.Model.TestObjects.Bases;

namespace CommonModel.Pages.Payment
{
    public abstract class UkPaymentPage : BasePaymentPage
    {
        protected UkPaymentPage(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public Button MakePaymentButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmButton)); }
        }
    }
}
