using Core.Contexts;
using TechTalk.SpecFlow;
using YoungsModel.Bases;
using YoungsModel.Pages;

namespace YoungsTests.Steps
{
    [Binding]
    public class TryOnSteps : YoungsStepBase
    {
        public TryOnSteps(Context context) : base(context)
        {
        }

        [When(@"I order a try on")]
        public void WhenIOrderATryOn()
        {
            OutfitSummaryPage.TotalPanel.OrderFreeTryOnButton.Click();
            TryOnBasketPage.SizeInfoPanel.SuitChestSelect.SelectByIndex(2);
            TryOnBasketPage.SizeInfoPanel.TrousersWaistSelect.SelectByIndex(2);

            TryOnBasketPage.SizeInfoPanel.SuitLengthSelect.SelectByIndex(2);
            TryOnBasketPage.SizeInfoPanel.TrousersInsideLegSelect.SelectByIndex(2);

            TryOnBasketPage.DeliveryAddressPanel.Address1 = "45 West Nile Street";
            TryOnBasketPage.DeliveryAddressPanel.City = "Glasgow";
            TryOnBasketPage.DeliveryAddressPanel.PostCode = "G1 2PT";
            TryOnBasketPage.DeliveryAddressPanel.UseEnteredAddressButton.Click();
            TryOnBasketPage.PhoneNumber = "07777000123";

            if (TryOnBasketPage.PreferredTryOnDatePicker.SelectedDateString == "")
            {
                TryOnBasketPage.PreferredTryOnDatePicker.SelectFirstAvailableDate();
            }
            TryOnBasketPage.TermsAndConditionsCheckbox.Check();

            TryOnBasketPage.ConfirmTryOnButton.Click();

            TryOnReviewPage.ConfirmTryOnButton.Click();

            PaymentPage.ConfirmationMethodPanel.EnterDefaultCreditCardDetailsButton.Click();
            PaymentPage.MakePaymentButton.Click();

            TryOnConfirmationPage.WaitUntilLoaded();
            Context.TryOn.OrderNumber = TryOnConfirmationPage.OrderNumber;
        }
    }
}
