using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public class Accessory : NonNeckwearBase
    {
        public Accessory(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
    }
}
