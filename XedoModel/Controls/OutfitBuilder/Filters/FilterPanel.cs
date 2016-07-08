using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OutfitBuilder.Filters
{
    public class FilterPanel : ControlBase
    {
        public FilterPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public SuitFilter SuitsFilter
        {
            get { return new SuitFilter(TestSettings); }
        }

        public NeckwearFilter NeckwearFilter
        {
            get { return new NeckwearFilter(TestSettings); }
        }

        public WaistcoatFilter WaistcoatFilter
        {
            get { return new WaistcoatFilter(TestSettings); }
        }

        public ShirtFilter ShirtFilter
        {
            get { return new ShirtFilter(TestSettings); }
        }

        public AccessoryFilter AccessoryFilter
        {
            get { return new AccessoryFilter(TestSettings); }
        }
        
        public class Locators
        {
            public static By Container = By.Id("filters-view");

        }
    }
}
