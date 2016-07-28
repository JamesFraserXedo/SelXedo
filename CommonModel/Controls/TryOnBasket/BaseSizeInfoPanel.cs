using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.TryOnBasket
{
    public abstract class BaseSizeInfoPanel : ControlBase
    {
        protected BaseSizeInfoPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Selector SuitChestSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.SuitChestSelect)); }
        }

        public Selector SuitLengthSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.SuitLengthSelect)); }
        }

        public Selector TrousersWaistSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.TrousersWaistSelect)); }
        }

        public Selector TrousersInsideLegSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.TrousersInsideLegSelect)); }
        }

        public Selector WaistcoatChestSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.WaistcoatChestSelect)); }
        }

        public Selector WaistcoatLengthSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.WaistcoatLengthSelect)); }
        }

        public IWebElement DoesNotIncludeFullMessage
        {
            get { return Driver.FindElement(Container, Locators.DoesNotIncludeFullMessage); }
        }
        
        public class Locators
        {
            public static By Container = By.ClassName("size-info-row");

            //TODO better hooks
            public static By SuitChestSelect = By.Name("Wearer.wearerOutfitModel.ClothingItemsList[0].PrimarySizes.SelectedSize");
            public static By SuitLengthSelect = By.Name("Wearer.wearerOutfitModel.ClothingItemsList[0].SecondarySizes.SelectedSize");
            public static By TrousersWaistSelect = By.Name("Wearer.wearerOutfitModel.ClothingItemsList[1].PrimarySizes.SelectedSize");
            public static By TrousersInsideLegSelect = By.Name("Wearer.wearerOutfitModel.ClothingItemsList[1].SecondarySizes.SelectedSize");
            public static By WaistcoatChestSelect = By.Name("Wearer.wearerOutfitModel.ClothingItemsList[2].PrimarySizes.SelectedSize");
            public static By WaistcoatLengthSelect = By.Name("Wearer.wearerOutfitModel.ClothingItemsList[2].SecondarySizes.SelectedSize");

            public static By DoesNotIncludeFullMessage = By.ClassName("unavailable-holder-wrap message-alerts message-announcement");
            public static By DoesNotIncludeItemsMessage = By.ClassName("unavailable-holder-wrap message-alerts message-announcement");
        }
    }
}
