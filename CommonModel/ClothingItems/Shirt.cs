using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public class Shirt : ClothingBase
    {
        public Shirt(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
    }
}
