using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OutfitBuilder.Choosers.Suits
{
    public class Suit : ClothingItem
    {
        public Suit(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {           
        }
                
        public bool HasPocket
        {
            get { return (ItemDetails.GetAttribute("data-jacket-haspocket") == "True"); }
        }
        
        public new class Locators : ClothingItem.Locators
        {
            public new static By ItemDetails = By.XPath(".//*[@data-level='jacket']");
        }
    }
}
