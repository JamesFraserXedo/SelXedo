using System.Threading;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common
{
    public class BaseDatePicker : ControlBase
    {
        private IWebElement _element;
        public BaseDatePicker(TestSettings testSettings, IWebElement element) : base(testSettings)
        {
            _element = element;
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }
        
        public IWebElement Body
        {
            get { return Driver.FindElement(Container, Locators.Body); }
        }

        public void SelectDate(string date)
        {
            Open();
            GoToMonth(int.Parse(date.Split('-')[1])+1);
            GoToYear(date.Split('-')[0]);
            Driver.FindElement(Container, Locators.FindDate(date)).Click();
        }

        public void SelectDate(int day, int month, int year)
        {
            GoToMonth(month);
            GoToYear(year.ToString());

            Driver.FindElement(Container, Locators.FindDate(day, month, year)).Click();
        }
        
        public string SelectFirstAvailableDate()
        {
            return SelectAvailableDate(0);
        }

        public string SelectAvailableDate(int index)
        {
            Open();
            var element = Driver.FindElements(Locators.ValidDates)[index];
            var date = element.GetAttribute("data-full");
            SelectDate(date);
            return date;
        }

        public string SelectedDate
        {
            get { return Driver.FindElement(Container, Locators.SelectedDate).GetAttribute("data-full"); }
        }

        public string SelectedDateString
        {
            get { return _element.GetAttribute("value"); }
        }

        private void GoToYear(string year)
        {
            Driver.FindElement(Container, Locators.YearPicker).Click();
            Driver.FindElement(Body, By.XPath(string.Format("//div[@data-val='{0}']/div/div", year))).Click();
        }

        private void GoToMonth(int month)
        {
            Driver.FindElement(Container, Locators.MonthPicker).Click();
            Driver.FindElement(Body, By.XPath(string.Format("//div[@data-val='{0}']/div/div", month - 1))).Click();
        }

        public bool IsOpen
        {
         get { return Driver.ElementDisplayed(Locators.Container); }
        }

        private void Open()
        {
            if (!IsOpen)
            {
                _element.Click();
            }
        }

        private void Close()
        {
            if (IsOpen)
            {
                _element.Click();
            }
        }

        public class Locators
        {
            public static readonly By Container = By.ClassName("dw-cal-pnl");

            public static readonly By Body = By.ClassName("dw-cal-body");
            public static readonly By MonthPicker = By.ClassName("class='dw-cal-month");
            public static readonly By YearPicker = By.ClassName("class='dw-cal-year");
            public static readonly By SelectedDate = By.CssSelector("[aria-selected='true']");
            public static readonly By ValidDates = By.CssSelector("[class*='dw-cal-day-v']");

            public static By FindDate(int day, int month, int year)
            {
                return By.CssSelector(string.Format("[data-full='{0}-{1}-{2}']:not([class*='dw-cal-day-diff'])", year, month - 1, day));
            }
            
            public static By FindDate(string yyyymmdd)
            {
                return By.CssSelector(string.Format("[data-full='{0}']:not([class*='dw-cal-day-diff']", yyyymmdd));
            }
        }
    }
}
