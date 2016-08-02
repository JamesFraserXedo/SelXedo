using System;
using System.Diagnostics;
using System.Threading;
using Core.Model.SupportTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Core.Model.TestObjects.Bases
{
    public abstract class PageBase : TestObjectBase
    {
        protected int PageTimeoutSeconds = 60;

        protected PageBase(TestSettings testSettings) : base(testSettings)
        {
            //WaitUntilLoaded();
        }

        public string Url
        {
            get { return Driver.Url; }
        }

        public string Title
        {
            get { return Driver.Title; }
        }

        public string Source
        {
            get { return Driver.PageSource; }
        }

        public void Back()
        {
            Driver.Navigate().Back();
        }

        public void Forward()
        {
            Driver.Navigate().Forward();
        }

        public void WaitUntilLoaded()
        {
            var s = new Stopwatch();
            s.Start();

            while (s.Elapsed < TimeSpan.FromSeconds(PageTimeoutSeconds))
            {
                if (IsLoaded())
                {
                    return;
                }
                Thread.Sleep(1000);
            }
            s.Stop();
            throw new TimeoutException(string.Format("The page did not load within {0} seconds", PageTimeoutSeconds));
        }

        public abstract bool IsLoaded();

        //public abstract void SetupState();
    }
}
