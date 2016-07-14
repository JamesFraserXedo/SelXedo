using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.OutfitControls
{
    public abstract class ZoomableOutfitControls : BaseOutfitControls
    {
        protected ZoomableOutfitControls(TestSettings testSettings) : base(testSettings)
        {
        }

        public Button ZoomOutfitButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ZoomOutfitButton)); }
        }

        public new class Locators : BaseOutfitControls.Locators
        {
            public static readonly By ZoomOutfitButton = By.Id("zoom-outfit-button");
        }
    }

}
