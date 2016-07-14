using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitSummary.TotalPane
{
    public abstract class BaseTotalPanel : ControlBase
    {
        protected BaseTotalPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public abstract IWebElement Container { get; }

        public Button AddToOrderButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.AddToOrderButton)); }
        }

        public class Locators
        {
            public static readonly By AddToOrderButton = By.CssSelector("[data-at='lnk-add-to-order']");
        }
    }
}
