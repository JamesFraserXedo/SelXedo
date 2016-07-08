using System.Collections.ObjectModel;
using System.Linq;
using Core.Model.TestObjects.Bases;
using XedoModel.Controls.OutfitBuilder.Filters;

namespace XedoModel.Controls.OutfitBuilder.Choosers.Waistcoats
{
    public class WaistcoatChooser : ChooserBase
    {
        public WaistcoatChooser(TestSettings testSettings) : base(testSettings)
        {
        }

        public override void SelectItemByName(string name)
        {
            var e = FindItemByName(name);
            new Waistcoat(TestSettings, e).Select();
        }

        public override ReadOnlyCollection<ClothingItem> Items
        {
            get
            {
                var itemElements = Container.FindElements(Locators.Items);
                var items = itemElements.Select(itemElement => new Waistcoat(TestSettings, itemElement)).Cast<ClothingItem>().ToList();
                return items.AsReadOnly();
            }
        }

        public override ClothingType ClothingType
        {
            get { return ClothingType.Waistcoat; }
        }
    }
}
