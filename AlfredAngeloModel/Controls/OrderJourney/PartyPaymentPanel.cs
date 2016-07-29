using CommonModel.Controls.OrderJourney.PartyPaymentPanel;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace AlfredAngeloModel.Controls.OrderJourney
{
    public class PartyPaymentPanel : UkPartyPaymentPanel
    {
        public PartyPaymentPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
    }
}
