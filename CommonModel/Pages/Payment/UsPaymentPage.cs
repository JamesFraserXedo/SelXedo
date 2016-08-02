using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;

namespace CommonModel.Pages.Payment
{
    public abstract class UsPaymentPage : BasePaymentPage
    {
        protected UsPaymentPage(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public Button ConfirmButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmButton)); }
        }
    }
}
