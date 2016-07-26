using Core.CustomElements;
using Core.Model.TestObjects.Bases;
namespace CommonModel.Pages.TryOnPayment
{
    public abstract class UsTryOnPaymentPage : BaseTryOnPaymentPage
    {
        protected UsTryOnPaymentPage(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public Button ConfirmButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmButton)); }
        }
    }
}
