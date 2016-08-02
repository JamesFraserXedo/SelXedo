using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters
{
    public abstract class BaseFilter : ControlBase
    {
        protected BaseFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public abstract IWebElement Container { get; }

        public IWebElement Header
        {
            get { return Driver.FindElement(Container, Locators.Header); }
        }

        public virtual void Select()
        {
            Header.Click();
        }

        public class Locators
        {
            public static readonly By Header = By.CssSelector("[class='filters-title']");

        }
    }
}
