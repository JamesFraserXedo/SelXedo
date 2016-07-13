using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonModel.Controls.OutfitBuilder.FiltersPanel;
using Core.Model.TestObjects.Bases;

namespace CommonModel.Pages
{
    public abstract class BaseOutfitBuilderPage : PageBase
    {
        protected BaseOutfitBuilderPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public abstract BaseFilterPanel BaseFilterPanel { get; protected set; }
        //public abstract BaseCataloguePanel BaseCataloguePanel { get; protected set; }
        
    }
}
