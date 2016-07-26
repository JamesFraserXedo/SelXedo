using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core.CustomElements
{
    public class InputBox
    {
        private IWebElement _element;

        public InputBox(IWebElement element)
        {
            _element = element;
        }

        public void Clear()
        {
            _element.Clear();
        }

        public void Click()
        {
            _element.Click();
        }

        public string Text
        {
            get { return _element.Text; }
        }

        public void SendKeys(string keys)
        {
            _element.SendKeys(keys);
        }

        public void Input(string keys)
        {
            Click();
            Clear();
            SendKeys(keys);
        }
    }
}
