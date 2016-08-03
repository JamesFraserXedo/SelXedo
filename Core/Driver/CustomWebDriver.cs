using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.SupportTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Core.Driver
{
    public class CustomWebDriver : IWebDriver
    {
        private IWebDriver _driver;
        public CustomWebDriver(IWebDriver driver)
        {
            _driver = driver;
        }

        public IJavaScriptExecutor IJavaScriptExecutor
        {
            get { return ((IJavaScriptExecutor) _driver); }
        }

        public ITakesScreenshot ITakesScreenshot
        {
            get { return ((ITakesScreenshot)_driver); }
        }

        public void ShowElementOnScreen(IWebElement element)
        {
            var script = "window.scrollTo(" + element.Location.X + "," + (element.Location.Y - 400) + ");";
            ((IJavaScriptExecutor)_driver).ExecuteScript(script);
        }

        public IWebElement FindElement(By @by)
        {
            return FindElement(by, Utils.Timeouts.StandardTimeout);
        }

        public IWebElement FindElement(By by, int timeout = Utils.Timeouts.StandardTimeout)
        {
            IWebElement element;
            if (timeout > 0)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
                element = wait.Until(drv => _driver.FindElement(by));
            }
            else
            {
                element = _driver.FindElement(by);
            }
            ShowElementOnScreen(element);
            return element;
        }

        public IWebElement FindElement(IWebElement parent, By by, int timeout = Utils.Timeouts.StandardTimeout)
        {
            IWebElement element;
            if (timeout > 0)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
                element = wait.Until(drv => parent.FindElement(by));
            }
            else
            {
                element = parent.FindElement(by);
            }
            ShowElementOnScreen(element);
            return element;
        }
        
        public ReadOnlyCollection<IWebElement> FindElements(By @by)
        {
            return _driver.FindElements(by);
        }

        public void Dispose()
        {
            _driver.Dispose();
        }

        public void Close()
        {
            _driver.Close();
        }

        public void Quit()
        {
            _driver.Quit();
        }

        public IOptions Manage()
        {
            return _driver.Manage();
        }

        public INavigation Navigate()
        {
            return _driver.Navigate();
        }

        public ITargetLocator SwitchTo()
        {
            return _driver.SwitchTo();
        }

        public string Url
        {
            get { return _driver.Url; }
            set { _driver.Url = value; }
        }

        public string Title
        {
            get { return _driver.Title; }
        }

        public string PageSource { get { return _driver.PageSource; } }
        public string CurrentWindowHandle { get { return _driver.CurrentWindowHandle; } }
        public ReadOnlyCollection<string> WindowHandles { get { return _driver.WindowHandles; } }
    }
}
