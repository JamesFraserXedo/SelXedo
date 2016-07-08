using System.Collections.ObjectModel;
using System.Linq;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using XedoModel.Controls.OutfitBuilder.Filters;

namespace XedoModel.Controls.OutfitBuilder.Choosers.Neckwears
{
    public class NeckwearChooser : ChooserBase
    {
        public NeckwearChooser(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public override void SelectItemByName(string name)
        {
            var e = FindItemByName(name);
            new Neckwear(TestSettings, e).Select();
        }

        public override ReadOnlyCollection<ClothingItem> Items
        {
            get
            {
                var itemElements = Container.FindElements(Locators.Items);
                var items = itemElements.Select(itemElement => new Neckwear(TestSettings, itemElement)).Cast<ClothingItem>().ToList();
                return items.AsReadOnly();
            }
        }

        public override ClothingType ClothingType
        {
            get { return ClothingType.Neckwear; } 
        }

        public void ShowTies()
        {
            Driver.FindElement(Container, Locators.TieOptionsSelector).Click();
        }

        public void ShowBowTies()
        {
            Driver.FindElement(Container, Locators.BowTieOptionsSelector).Click();
        }

        public new class Locators : ChooserBase.Locators
        {
            public static By TieOptionsSelector = By.XPath("//*[contains(@class, 'neckwear-holder click-target')][1]");
            public static By BowTieOptionsSelector = By.XPath("//*[contains(@class, 'neckwear-holder click-target')][2]");
        }
    }
}
