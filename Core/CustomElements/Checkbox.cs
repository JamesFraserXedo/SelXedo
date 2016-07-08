using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core.CustomElements
{
    public class Checkbox
    {
        private IWebElement _element;

        public Checkbox(IWebElement element)
        {
            _element = element;
        }

        public bool Checked
        {
            get { return _element.Selected; }
        }

        public void Check()
        {
            if (Checked)
            {
                return;
            }
            _element.Click();
        }

        public void Uncheck()
        {
            if (!Checked)
            {
                return;
            }
            _element.Click();
        }
    }
}
