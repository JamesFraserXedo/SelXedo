using Core.CustomElements;
using Core.Model.TestObjects.Bases;
namespace CommonModel.Pages.TryOnPayment
{
    public abstract class UkTryOnPaymentPage : BaseTryOnPaymentPage
    {
        protected UkTryOnPaymentPage(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public Button MakePaymentButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmButton)); }
        }
    }
}
