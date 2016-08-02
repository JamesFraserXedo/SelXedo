using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters
{
    public abstract class BaseExpandableFilter : BaseFilter
    {
        protected BaseExpandableFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Body
        {
            get { return Driver.FindElement(Container, Locators.Body); }
        }

        public bool Expanded
        {
            get { return Body.Displayed; }
        }

        public override void Select()
        {
            if (!Expanded)
            {
                Header.Click();
            }
        }

        public new class Locators : BaseFilter.Locators
        {
            public static readonly By Body = By.CssSelector("[class='filters-section-body']");
        }
    }
}
