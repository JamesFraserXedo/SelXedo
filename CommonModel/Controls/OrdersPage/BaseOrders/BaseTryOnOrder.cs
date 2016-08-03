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
    public abstract class BaseTryOnOrder : ActiveOrder
    {
        protected BaseTryOnOrder(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        protected IWebElement TryOnWearerLabel
        {
            get { return Driver.FindElement(Container, Locators.ThirdColumnCell); }
        }

        protected IWebElement DeliveryDateLabel
        {
            get { return Driver.FindElement(Container, Locators.FourthColumnCell); }
        }

        public string TryOnWearer
        {
            get { return TryOnWearerLabel.Text; }
        }

        public string DeliveryDate
        {
            get { return DeliveryDateLabel.Text; }
        }
    }
}
