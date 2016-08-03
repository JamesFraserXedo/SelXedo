using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.TidioChat
{
    public class Chatbox : ControlBase
    {
        private const string FrameName = "tidio-chat";

        public Chatbox(TestSettings testSettings) : base(testSettings)
        {
        }

        private void SwitchToChatFrame()
        {
            Driver.SwitchTo().Frame(FrameName);
        }

        private void SwitchToMainContent()
        {
            Driver.SwitchTo().DefaultContent();
        }

        private Button ChatboxButton
        {
            get { return new Button(Driver.FindElement(Locators.ChatboxButton)); }
        }

        private Button CloseButton
        {
            get { return new Button(Driver.FindElement(Locators.CloseButton)); }
        }

        private bool Opened
        {
            get { return Driver.ElementDisplayed(Locators.CloseButton); }
        }

        public void Open()
        {
            SwitchToChatFrame();
            if (!Opened)
            {
                ChatboxButton.Click();
            }
            SwitchToMainContent();
        }

        public void Close()
        {
            SwitchToChatFrame();
            if (Opened)
            {
                CloseButton.Click();
            }
            SwitchToMainContent();
        }

        public class Locators
        {
            public static readonly By ChatboxButton = By.Id("tidio-chat-button");
            public static readonly By CloseButton = By.CssSelector(".image");
        }
    }
}
