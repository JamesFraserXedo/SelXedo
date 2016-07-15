using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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

        public SelectElement SuitChestSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.SuitChestSelect)); }
        }

        public SelectElement SuitLengthSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.SuitLengthSelect)); }
        }

        public SelectElement TrousersWaistSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.TrousersWaistSelect)); }
        }

        public SelectElement TrousersInsideLegSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.TrousersInsideLegSelect)); }
        }

        public SelectElement WaistcoatChestSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.WaistcoatChestSelect)); }
        }

        public SelectElement WaistcoatLengthSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.WaistcoatLengthSelect)); }
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
