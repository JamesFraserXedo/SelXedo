using System.Threading;
using Core.Contexts;
using Core.Model.SupportTools;
using TechTalk.SpecFlow;
using XedoModel.Bases;
using XedoModel.Pages.PaymentProcess;

namespace XedoTests.Steps
{
    [Binding]
    public class BillingAddressSteps : XedoStepBase
    {
        public BillingAddressSteps(Context context) : base(context)
        {
        }

        [When(@"I complete billing")]
        public void WhenICompleteBilling()
        {
            if (Driver.ElementDisplayed(BillingAddressPage.Locators.ConfirmListedAddressButton))
            {
                BillingAddressPage.ConfirmListedAddressButton.Click();
            }
            else
            {
                BillingAddressPage.Address1 = "4400 Quality Drive";
                BillingAddressPage.State = "TN";
                BillingAddressPage.Zipcode = "30329";
                BillingAddressPage.ConfirmEnteredAddressButton.Click();

                //Driver.WaitForElementToAppear(By.Id("confirm-suggested-address"));
                //Driver.FindElement(By.Id("confirm-suggested-address")).Click();
            }
            BillingAddressPage.ContactNumber = "866-574-6088";
            Thread.Sleep(3000);
            BillingAddressPage.PaymentOptionsButton.Click();
        }
    }
}

        
