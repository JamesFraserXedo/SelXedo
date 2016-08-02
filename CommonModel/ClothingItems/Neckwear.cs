using System.Threading;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public class Neckwear : ClothingBase
    {
        public Neckwear(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public override string Id
        {
            get { return Utils.StripBreaks(_container.GetAttribute("id")); }
        }

        public override string Name
        {
            get { return Utils.StripBreaks(Driver.FindElement(_container, Locators.NameLabel).Text); }
        }
        
        public string HankieImagePath
        {
            get { return _container.GetAttribute("data-hankie-src"); }
        }

        public string TieType
        {
            get
            {
                var type = _container.GetAttribute("data-neckwear-type");
                if (type == "1")
                {
                    return "Ruche";
                }
                if (type == "2")
                {
                    return "Tie";
                }
                if (type == "3")
                {
                    return "Bow tie";
                }
                return type;
            }
        }

        public override bool Selected
        {
            get { return _container.GetAttribute("class").Contains("selected"); }
        }

        public override void Select()
        {
            if (!Selected)
            {
                _container.Click();
            }
        }

        public override void Deselect()
        {
            if (Selected)
            {
                _container.Click();
            }
        }

        protected class Locators
        {
            public new static readonly By NameLabel = By.CssSelector("[class*='colour-name']"); 
        }
    }
}
