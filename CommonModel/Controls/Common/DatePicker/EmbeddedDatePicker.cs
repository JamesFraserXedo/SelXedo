using System;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.DatePicker
{
    public class EmbeddedDatePicker : ControlBase
    {
        public EmbeddedDatePicker(TestSettings testSettings) : base(testSettings)
        {
        }

        public void Select(int day, int month, int year)
        {
            SelectYear(year);
            SelectMonth(month - 1);
            Driver.FindElement(Locators.DateSelect(day, month, year)).Click();
        }


        private void SelectMonth(int month)
        {
            if (!Driver.ElementDisplayed(Locators.MonthSelect(month)))
            {
                Driver.FindElement(Locators.MonthLabel).Click();
            }
            Driver.FindElement(Locators.MonthSelect(month)).Click();
        }

        private void SelectYear(int year)
        {
            if (!Driver.ElementDisplayed(Locators.YearSelect(year)))
            {
                Driver.FindElement(Locators.YearLabel).Click();
            }
            Driver.FindElement(Locators.YearSelect(year)).Click();
        }

        public class Locators
        {
            public static readonly By MonthLabel = By.CssSelector("[class='dw-cal-month']");
            public static readonly By YearLabel = By.CssSelector("[class='dw-cal-year']");

            public static readonly By PreviousMonthButton = By.CssSelector("[aria-label='Previous Month']");
            public static readonly By NextMonthButton = By.CssSelector("[aria-label='Next Month']");
            public static readonly By PreviousYearByButton = By.CssSelector("[aria-label='Previous Year']");
            public static readonly By NextYearButton = By.CssSelector("[aria-label='Next Year']");

            public static readonly By ValidDates = By.CssSelector("[class*='dw-cal-day-v']");

            public static By DateSelect(int day, int month, int year)
            {
                return By.CssSelector(string.Format("[data-full='{0}-{1}-{2}']", year, month, day));
            }

            public static By MonthSelect(int month)
            {
                return By.CssSelector(String.Format("[data-val='{0}'][aria-label]", month));
            }

            public static By MonthSelect(string month)
            {
                month = month.ToLower();
                if (month.StartsWith("jan"))
                {
                    return MonthSelect(0);
                }
                if (month.StartsWith("feb"))
                {
                    return MonthSelect(1);
                }
                if (month.StartsWith("mar"))
                {
                    return MonthSelect(2);
                }
                if (month.StartsWith("apr"))
                {
                    return MonthSelect(3);
                }
                if (month.StartsWith("may"))
                {
                    return MonthSelect(4);
                }
                if (month.StartsWith("jun"))
                {
                    return MonthSelect(5);
                }
                if (month.StartsWith("jul"))
                {
                    return MonthSelect(6);
                }
                if (month.StartsWith("aug"))
                {
                    return MonthSelect(7);
                }
                if (month.StartsWith("sep"))
                {
                    return MonthSelect(8);
                }
                if (month.StartsWith("oct"))
                {
                    return MonthSelect(9);
                }
                if (month.StartsWith("nov"))
                {
                    return MonthSelect(10);
                }
                if (month.StartsWith("dec"))
                {
                    return MonthSelect(11);
                }
                throw new ArgumentException(String.Format("Could not recognise month '{0}'", month));
            }

            public static By YearSelect(int year)
            {
                return YearSelect(year.ToString());
            }

            public static By YearSelect(string year)
            {
                return By.CssSelector(String.Format("[data-val='{0}'][role='button']", year));
            }
        }
    }
}
