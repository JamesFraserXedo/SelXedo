using OpenQA.Selenium;

namespace Core.CustomElements
{
    public class Button
    {
        private IWebElement _element;

        public Button(IWebElement element)
        {
            _element = element;
        }

        public string Text
        {
            get { return _element.Text; }
        }

        public void Click()
        {
            _element.Click();
        }
    }
}
