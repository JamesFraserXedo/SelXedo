using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public class Suit : NonNeckwearBase
    {
        public Suit(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
        
        public bool HasPocket
        {
            get { return DetailsElement.GetAttribute("data-jacket-haspocket").ToLower() == "true"; }
        }
        
        public string TrousersImagePath
        {
            get { return DetailsElement.GetAttribute("data-trousers-preview"); }
        }
    }
}
