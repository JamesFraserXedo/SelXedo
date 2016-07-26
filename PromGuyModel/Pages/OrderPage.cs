using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonModel.Controls.Common;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace PromGuyModel.Pages
{
    public class OrderPage : PageBase
    {
        public OrderPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public MinimisedDatePicker DatePicker
        {
            get { return new MinimisedDatePicker(TestSettings, Driver.FindElement(Locators.EventDatePicker)); }
        }

        public class Locators
        {
            public static readonly By EventDatePicker = By.Id("event-calendar");
        }
    }
}
