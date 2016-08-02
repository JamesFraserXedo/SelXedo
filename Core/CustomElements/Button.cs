using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Core.CustomElements
{
    public class Button
    {
        private readonly IWebElement _element;

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
