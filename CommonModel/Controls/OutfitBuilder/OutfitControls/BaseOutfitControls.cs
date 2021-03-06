﻿using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.OutfitBuilder.OutfitControls
{
    public abstract class BaseOutfitControls : ControlBase
    {
        protected BaseOutfitControls(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Button SaveOutfitButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.SaveOutfitButton)); }
        }

        public Button ToggleJacketButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ToggleJacketButton)); }
        }

        public Button ClearOutfitButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ClearOutfitButton)); }
        }

        public Button ExpandButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ExpandButton)); }
        }

        public class Locators
        {
            public static readonly By Container = By.CssSelector("[class='outfit-controls']");
            public static readonly By SaveOutfitButton = By.Id("save-outfit-only-button");
            public static readonly By ToggleJacketButton = By.Id("remove-jacket-button");
            public static readonly By ClearOutfitButton = By.Id("clear-outfit-button");
            public static readonly By ExpandButton = By.Id("expand-help-section-button");
        }
    }
}
