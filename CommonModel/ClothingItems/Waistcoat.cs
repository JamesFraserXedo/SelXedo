using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public class Waistcoat : NonNeckwearBase
    {
        public Waistcoat(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public bool IsWaistcoat
        {
            get { return DetailsElement.GetAttribute("data-at") == "lnk-waistcoat"; }
        }

        public bool IsCummerbund
        {
            get { return DetailsElement.GetAttribute("data-at") == "lnk-cummerbund"; }
        }
    }
}
