using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OutfitBuilder.Filters
{
    public class Colour : ControlBase
    {
        private IWebElement _element;

        public Colour(TestSettings testSettings, IWebElement element) : base(testSettings)
        {
            _element = element;
        }

        public string Name
        {
            get { return _element.GetAttribute("data-colour-desc"); }
        }

        public string ColourCode
        {
            get { return _element.GetAttribute("data-crumb"); }
        }

        public bool Selected 
        {
            get { return _element.GetAttribute("class").Contains("selected"); }
        }

        public void Select()
        {
            if (Selected)
            {
                return;
            }
            _element.Click();
        }

        public void Deselect()
        {
            if (!Selected)
            {
                return;
            }
            _element.Click();
        }
    }
}
