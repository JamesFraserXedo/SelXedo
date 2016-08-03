using System;
using System.Linq;
using Core.Contexts;
using Core.Model.SupportTools;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using YoungsModel.Bases;

namespace YoungsTests.Steps.ProfileSteps
{
    [Binding]
    public class OrderPageSteps : YoungsStepBase
    {
        public OrderPageSteps(Context context) : base(context)
        {
        }

        [When(@"I view the try on from the orders page")]
        public void WhenIViewTheTryOnFromTheOrdersPage()
        {
            Header.OrdersLink.Click();
            OrdersPage.WaitUntilLoaded();
            var tryOnOrder = OrdersPage.TryOnOrders.First(o => o.OrderNumber == Context.TryOn.OrderNumber);
            tryOnOrder.GoToOrderButton.Click();
        }

        [Then(@"I should be on the complete your order page")]
        public void ThenIShouldBeOnTheCompleteYourOrderPage()
        {
            Assert.That(Driver.ElementDisplayed(By.CssSelector("[class='tryon-to-order-cta-prompt']")), "Did not appear to be on the complete your order page.");
        }
    }
}
