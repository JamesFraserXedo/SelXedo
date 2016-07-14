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

        protected new IWebElement DetailsElement
        {
            get { return _container; }
        }

        public new string Id
        {
            get { return Utils.StripBreaks(_container.GetAttribute("id")); }
        }

        public new string Name
        {
            get { return Utils.StripBreaks(Driver.FindElement(_container, Locators.Name).Text); }
        }
        
        public string HankieImagePath
        {
            get { return _container.GetAttribute("data-hankie-src"); }
        }

        public string TieType
        {
            get
            {
                string type = _container.GetAttribute("data-neckwear-type");
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

        public new bool Selected
        {
            get { return _container.GetAttribute("class").Contains("selected"); }
        }

        protected new class Locators : ClothingBase.Locators
        {
            public static By Name = By.ClassName("item-text-link"); // Needs data-at hook
        }
    }
}
