using System.Collections.ObjectModel;
using System.Linq;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using Core.Controls.OutfitBuilder.Filters;

namespace Core.Controls.OutfitBuilder.Choosers.Shirts
{
    public class ShirtChooser : ChooserBase
    {
        public ShirtChooser(TestSettings testSettings) : base(testSettings)
        {
        }

        public override void SelectItemByName(string name)
        {
            var e = FindItemByName(name);
            new Shirt(TestSettings, e).Select();
        }

        public override ReadOnlyCollection<ClothingItem> Items
        {
            get
            {
                var itemElements = Container.FindElements(Locators.Items);
                var items = itemElements.Select(itemElement => new Shirt(TestSettings, itemElement)).Cast<ClothingItem>().ToList();
                return items.AsReadOnly();
            }
        }

        public override ClothingType ClothingType
        {
            get { return ClothingType.Shirt; }
        }
    }
}
