using System;
using System.Linq;
using Core.Controls.OutfitBuilder.Choosers;
using Core.Controls.OutfitBuilder.Choosers.Accessories;
using Core.Controls.OutfitBuilder.Choosers.Neckwears;
using Core.Controls.OutfitBuilder.Choosers.Shirts;
using Core.Controls.OutfitBuilder.Choosers.Suits;
using Core.Controls.OutfitBuilder.Choosers.Waistcoats;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OutfitBuilder.Choosers
{
    public class ChooserPanel : ControlBase
    {
        public ChooserPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement OutfitSummaryButton
        {
            get { return Driver.FindElement(Container, Locators.OutfitSummaryButton); }
        }

        public IWebElement NextSectionButton
        {
            get { return Driver.FindElement(Container, Locators.NextSectionButton); }
        }

        public IWebElement PreviousSectionButton
        {
            get { return Driver.FindElement(Container, Locators.PreviousSectionButton); }
        }

        public SuitChooser SuitChooser
        {
            get { return new SuitChooser(TestSettings); }
        }

        public WaistcoatChooser WaistcoatChooser
        {
            get { return new WaistcoatChooser(TestSettings); }
        }

        public NeckwearChooser NeckwearChooser
        {
            get { return new NeckwearChooser(TestSettings); }
        }

        public ShirtChooser ShirtChooser
        {
            get { return new ShirtChooser(TestSettings); }
        }

        public AccessoryChooser AccessoryChooser
        {
            get { return new AccessoryChooser(TestSettings); }
        }

        public ChooserBase CurrentChooser
        {
            get {
                if (Container.FindElements(Locators.SuitDetector).Any()) { return new SuitChooser(TestSettings); }
                if (Container.FindElements(Locators.NeckwearDetector).Any()) { return new NeckwearChooser(TestSettings); }
                if (Container.FindElements(Locators.WaistcoatDetector).Any()) { return new WaistcoatChooser(TestSettings); }
                if (Container.FindElements(Locators.ShirtDetector).Any()) { return new ShirtChooser(TestSettings); }
                if (Container.FindElements(Locators.AccessoryDetector).Any()) { return new AccessoryChooser(TestSettings); }
                throw new Exception("Could not determine what chooser item is present");
            }
        }

        public class Locators
        {
            public static By Container = By.XPath("//div[@class='catalogue-outfit-holder']");
            public static By NeckwearDetector = By.XPath("//*[@class='neckwear-colours-holder']");
            public static By WaistcoatDetector = By.XPath("//*[@class='item-container all-waistcoats mobile-container-selector']");
            public static By ShirtDetector = By.XPath("//*[@class='item shirt']");
            public static By AccessoryDetector = By.XPath("//*[@class='item accessory']");
            public static By SuitDetector = By.XPath("//*[@class='item suit']");
            public static By OutfitSummaryButton = By.Id("outfit-summary-button");
            public static By NextSectionButton = By.XPath("//*[@class='iconset-chevron-right ob-arrow-icon tooltip-toggle']");
            public static By PreviousSectionButton = By.XPath("//*[@class='iconset-chevron-left ob-arrow-icon tooltip-toggle']");
        }
    }
}
