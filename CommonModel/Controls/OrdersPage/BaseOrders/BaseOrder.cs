using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrdersPage.BaseOrders
{
    public abstract class BaseOrder : ControlBase
    {
        public IWebElement Container;
        protected BaseOrder(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            Container = container;
        }

        protected IWebElement OrderNumberLabel
        {
            get { return Driver.FindElement(Container, Locators.OrderNumberLabel); }
        }

        protected IWebElement CreatedDateLabel
        {
            get { return Driver.FindElement(Container, Locators.CreatedDateLabel); }
        }

        public string OrderNumber
        {
            get { return OrderNumberLabel.Text; }
        }

        public string CreatedDate
        {
            get { return CreatedDateLabel.Text; }
        }

        public class Locators
        {
            public static readonly By OrderNumberLabel = By.CssSelector("td:nth-of-type(1)");
            public static readonly By CreatedDateLabel = By.CssSelector("td:nth-of-type(2)");
            public static readonly By ThirdColumnCell = By.CssSelector("td:nth-of-type(3)");
            public static readonly By FourthColumnCell = By.CssSelector("td:nth-of-type(4)");
        }
    }
}
