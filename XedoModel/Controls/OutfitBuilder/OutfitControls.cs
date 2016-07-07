﻿using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace Core.Controls.OutfitBuilder
{
    public class OutfitControls : ControlBase
    {
        public OutfitControls(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement SaveToFavouritesButton
        {
            get { return Driver.FindElement(Container, Locators.SaveToFavouritesButton); }
        }

        public IWebElement HideJacketButton
        {
            get { return Driver.FindElement(Container, Locators.HideJacketButton); }
        }

        public IWebElement ClearTuxButton
        {
            get { return Driver.FindElement(Container, Locators.ClearTuxButton); }
        }

        public IWebElement ZoomOutfitButton
        {
            get { return Driver.FindElement(Container, Locators.ZoomOutfitButton); }
        }

        public IWebElement ExpandControlsButton
        {
            get { return Driver.FindElement(Container, Locators.ExpandControlsButton); }
        }

        public void ClearTux()
        {
            ClearTuxButton.Click();
        }

        public class Locators
        {
            public static By Container = By.XPath("//nav[contains(@class, 'outfit-controls')]");
            public static By SaveToFavouritesButton = By.Id("save-outfit-only-button");
            public static By HideJacketButton = By.Id("remove-jacket-button");
            public static By ClearTuxButton = By.Id("clear-outfit-button");
            public static By ZoomOutfitButton = By.Id("zoom-outfit-button");
            public static By ExpandControlsButton = By.Id("expand-help-section-button");
        }
    }
}
