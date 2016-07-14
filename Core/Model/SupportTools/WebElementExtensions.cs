using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace Core.Model.SupportTools
{
    public static class WebElementExtensions
    {
        public static void SendKeysSlowly(this IWebElement element, string text, int mSecDelay = 250)
        {
            Utils.SendKeysSlowly(element, text, mSecDelay);
        }

        public static IWebElement GetParent(this IWebElement element)
        {
            var driver = ((IWrapsDriver)element).WrappedDriver;
            return (IWebElement) ((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].parentNode;", element);
        }
    }
}
