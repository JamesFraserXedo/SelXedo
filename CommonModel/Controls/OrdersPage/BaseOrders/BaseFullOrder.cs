using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrdersPage.BaseOrders
{
    public abstract class BaseFullOrder : ActiveOrder
    {
        protected BaseFullOrder(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        protected IWebElement WeddingPartyLabel
        {
            get { return Driver.FindElement(Container, Locators.ThirdColumnCell); }
        }

        protected IWebElement EventDateLabel
        {
            get { return Driver.FindElement(Container, Locators.FourthColumnCell); }
        }

        public string WeddingParty
        {
            get { return WeddingPartyLabel.Text; }
        }

        public string EventDate
        {
            get { return EventDateLabel.Text; }
        }
    }
}
