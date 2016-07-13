using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                base.Select();
            }
        }

        public new class Locators : BaseFilter.Locators
        {
            public static By Body = By.ClassName("filters-section-body");
        }
    }
}
