using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public class Shirt : NonNeckwearBase
    {
        public Shirt(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
    }
}
