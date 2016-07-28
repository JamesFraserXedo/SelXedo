using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core.CustomElements
{
    public class Inputbox
    {
        private IWebElement _element;

        public Inputbox(IWebElement element)
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

        public void Append(string keys)
        {
            _element.SendKeys(keys);
        }

        public void SendKeys(string keys)
        {
            Click();
            Clear();
            Append(keys);
        }
    }
}
