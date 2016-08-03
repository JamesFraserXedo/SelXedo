using System.Collections.ObjectModel;
using Core.Driver;
using OpenQA.Selenium;

namespace Core.Model.SupportTools
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, IWebElement parent, By loc)
        {
            return Utils.FindElement(driver, parent, loc);
        }

        public static void ShowElementOnScreen(this IWebDriver driver, IWebElement element)
        {
            var script = "window.scrollTo(" + element.Location.X + "," + (element.Location.Y - 400) + ");";
            Utils.IJavaScriptExecutor(driver).ExecuteScript(script);
        }

        public static bool ElementDisplayed(this IWebDriver driver, By loc)
        {
            return Utils.ElementDisplayed(driver, loc);
        }

        public static bool ElementDisplayed(this IWebDriver driver, IWebElement parent, By loc)
        {
            return Utils.ElementDisplayed(driver, parent, loc);
        }

        public static void WaitForElementToAppear(this IWebDriver driver, By loc, int timeout = Utils.Timeouts.StandardTimeout)
        {
            Utils.WaitForElementToAppear(driver, loc, timeout);
        }

        public static void WaitForElementToDisappear(this IWebDriver driver, By loc, int timeout = Utils.Timeouts.StandardTimeout)
        {
            Utils.WaitForElementToDisappear(driver, loc, timeout);
        }

        public static ReadOnlyCollection<IWebElement> FindDisplayedElements(this IWebDriver driver, By loc)
        {
            return Utils.FindDisplayedElements(driver, loc);
        }

        public static bool ElementExists(this IWebDriver driver, By loc)
        {
            return Utils.ElementExists(driver, loc);
        }

        public static bool ElementExists(this IWebDriver driver, IWebElement parent, By loc)
        {
            return Utils.ElementExists(parent, loc);
        }
    }
}
