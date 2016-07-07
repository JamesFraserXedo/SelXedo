using OpenQA.Selenium;

namespace Core.Model.SupportTools
{
    public static class WebElementExtensions
    {
        public static void SendKeysSlowly(this IWebElement element, string text, int mSecDelay = 250)
        {
            Utils.SendKeysSlowly(element, text, mSecDelay);
        }
    }
}
