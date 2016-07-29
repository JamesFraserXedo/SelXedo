using CommonModel.Controls.OrderJourney.PartyPaymentPanel;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OrderJourney
{
    public class PartyPaymentPanel : UsPartyPaymentPanel
    {
        public PartyPaymentPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
    }
}
