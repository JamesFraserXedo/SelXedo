using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.QuickTryOn
{
    public class SelectedColour : ControlBase
    {
        private IWebElement _container;

        public SelectedColour(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public IWebElement ColourSample
        {
            get { return Driver.FindElement(_container, Locators.ColourSample); }
        }

        public IWebElement RemoveColourButton
        {
            get { return Driver.FindElement(_container, Locators.RemoveColourButton); }
        }

        public IWebElement NameLabel
        {
            get { return Driver.FindElement(_container, Locators.NameLabel); }
        }

        public string Name
        {
            get { return NameLabel.Text; }
        }

        public bool Selected
        {
            get { return Name != "Not Selected"; }
        }

        public void Remove()
        {
            if (Selected)
            {
                RemoveColourButton.Click();
            }
        }

        public class Locators
        {
            public static By ColourSample = By.XPath(".//span[@class='colour-sample']");
            public static By RemoveColourButton = By.XPath(".//a[@class='remove-colour-sample']");
            public static By NameLabel = By.XPath(".//span[@class='colour-sample-name']");

        }


    }
}
