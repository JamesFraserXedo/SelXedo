using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.HomePage
{
    public class ExploreTheCollectionsPanel : ControlBase
    {
        public ExploreTheCollectionsPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement Title
        {
            get { return Driver.FindElement(Container, Locators.Title); }
        }

        public ReadOnlyCollection<CollectionOutfit> Outfits
        {
            get
            {
                return Container.FindElements(Locators.Outfits).Select(e => new CollectionOutfit(TestSettings, e)).ToList().AsReadOnly();
            }
        } 

        public class Locators
        {
            public static By Container = By.Id("hp-Collections");
            public static By Title = By.CssSelector("h2");
            public static By Outfits = By.CssSelector("[class='inspire-item-inner collection-item-inner']");
        }
    }
}
