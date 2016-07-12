using OpenQA.Selenium;

namespace Core.CustomElements
{
    public class Link
    {
        private IWebElement _element;

        public Link(IWebElement element)
        {
            _element = element;
        }

        public string Text
        {
            get { return _element.Text; }
        }

        public string LinkPath
        {
            get { return _element.GetAttribute("href"); }
        }

        public bool Displayed
        {
            get { return _element.Displayed; }
        }

        public void Click()
        {
            _element.Click();
        }
    }
}
