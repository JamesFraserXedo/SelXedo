using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OutfitBuilder
{
    public class OutfitControls : ControlBase
    {
        public OutfitControls(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Button SaveToFavouritesButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.SaveToFavouritesButton)); }
        }

        public Button HideJacketButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.HideJacketButton)); }
        }

        public Button ClearOutfitButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ClearOutfitButton)); }
        }

        public Button ZoomOutfitButton 
        {
            get { return new Button(Driver.FindElement(Container, Locators.ZoomOutfitButton)); }
        }

        public Button ExpandControlsButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ExpandControlsButton)); }
        }
        
        public class Locators
        {
            public static By Container = By.ClassName("outfit-controls");
            public static By SaveToFavouritesButton = By.Id("save-outfit-only-button");
            public static By HideJacketButton = By.Id("remove-jacket-button");
            public static By ClearOutfitButton = By.Id("clear-outfit-button");
            public static By ZoomOutfitButton = By.Id("zoom-outfit-button");
            public static By ExpandControlsButton = By.Id("expand-help-section-button");
        }
    }
}
