using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Core.CustomElements
{
    public class Selector : SelectElement
    {
        public Selector(IWebElement element) : base(element)
        {
        }

        public void SelectByTextThenValue(string text)
        {
            var options = Options.Select(o => o.Text).ToList();
            if (options.Any(o => o == text))
            {
                SelectByText(text);
                return;
            }

            var values = Options.Select(o => o.GetAttribute("value")).ToList();
            if (values.Any(v => v == text))
            {
                SelectByValue(text);
                return;
            }
            SelectByText(text);
        }
    }
}
