using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.Controls.CollectionsPage;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Pages
{
    public class CollectionsPage : PageBase
    {
        public CollectionsPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.Identifier);
        }

        public ReadOnlyCollection<Collection> Collections
        {
            get
            {
                return
                    Driver.FindElements(Locators.Collections)
                        .Select(e => new Collection(TestSettings, e))
                        .ToList()
                        .AsReadOnly();
            }
        }

        public class Locators
        {
            public static readonly By Identifier = By.CssSelector("[class='collections-page-body']");
            public static readonly By Collections = By.CssSelector("[class='inspire-item collection-single']");
        }
    }
}
