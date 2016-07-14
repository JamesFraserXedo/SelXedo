using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder
{
    public abstract class BaseOutfitViewer : ControlBase
    {
        protected BaseOutfitViewer(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public bool InitialImagePresent
        {
            get { return Driver.ElementDisplayed(Container, Locators.InitialImage); }
        }

        public bool HankieImagePresent
        {
            get { return Driver.FindElement(Container, Locators.HankieImage).GetAttribute("src") != null; }
        }

        public bool JacketImagePresent
        {
            get { return Driver.ElementDisplayed(Container, Locators.JacketImage); }
        }

        public bool TrousersImagePresent
        {
            get { return Driver.ElementDisplayed(Container, Locators.TrousersImage); }
        }

        public bool WaistcoatImagePresent
        {
            get { return Driver.ElementDisplayed(Container, Locators.WaistcoatImage); }
        }

        public bool NeckwearImagePresent
        {
            get { return Driver.ElementDisplayed(Container, Locators.NeckwearImage); }
        }

        public string InitialImageSource
        {
            get { return Driver.FindElement(Container, Locators.InitialImage).GetAttribute("src"); }
        }

        public string HankieImageSource
        {
            get { return Driver.FindElement(Container, Locators.HankieImage).GetAttribute("src"); }
        }

        public string JacketImageSource
        {
            get { return Driver.FindElement(Container, Locators.JacketImage).GetAttribute("src"); }
        }

        public string TrousersImageSource
        {
            get { return Driver.FindElement(Container, Locators.TrousersImage).GetAttribute("src"); }
        }

        public string WaistcoatImageSource
        {
            get { return Driver.FindElement(Container, Locators.WaistcoatImage).GetAttribute("src"); }
        }

        public string NeckwearImageSource
        {
            get { return Driver.FindElement(Container, Locators.NeckwearImage).GetAttribute("src"); }
        }

        public class Locators
        {
            public static By Container = By.Id("outfit-view");
            public static By InitialImage = By.Id("initial-image");
            public static By HankieImage = By.Id("hankie-image");
            public static By JacketImage = By.ClassName("img-responsive ob-image jacket");
            public static By TrousersImage = By.ClassName("img-responsive ob-image trousers");
            public static By WaistcoatImage = By.ClassName("img-responsive ob-image waistcoat");
            public static By NeckwearImage = By.ClassName("img-responsive ob-image neckwear");
        }
    }
}
