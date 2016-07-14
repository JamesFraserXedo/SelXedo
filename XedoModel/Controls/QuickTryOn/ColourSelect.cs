﻿using System.Collections.Generic;
using System.Linq;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.QuickTryOn
{
    public class ColourSelect : ControlBase
    {
        public ColourSelect(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement ColourFamilyChooser
        {
            get { return Driver.FindElement(Container, Locators.ColourFamilyChooser); }
        }

        public IWebElement ColourChooser
        {
            get { return Driver.FindElement(Container, Locators.ColourChooser); }
        }

        public IWebElement ColourLimitReachedMessage
        {
            get { return Driver.FindElement(Container, Locators.ColourLimitReachedMessage); }
        }
        
        public void SelectColourFamily(string colour)
        {
            ColourFamilyChooser.FindElement(By.XPath("//a[@title='" + colour + "']")).Click();
        }

        public string SelectedColourFamily
        {
            get { return Driver.FindElement(Container, Locators.SelectedColourFamilyBox).GetAttribute("title"); }
        }

        public void SelectColour(string colour)
        {
            if (FirstSelectedColour.Name == colour || SecondSelectedColour.Name == colour)
            {
                return;
            }
            ColourChooser.FindElement(By.XPath("//a[@title='" + colour + "']")).Click();
        }

        public void DeselectByRemovingColour(string colour)
        {
            if (FirstSelectedColour.Name == colour)
            {
                FirstSelectedColour.Remove();
                return;
            }
            if (SecondSelectedColour.Name == colour)
            {
                SecondSelectedColour.Remove();
            }
        }

        public IWebElement ChooseFirstAvailableColour()
        {
            Driver.FindElement(ColourFamilyChooser, Locators.ColourFamilyChoices).Click();
            var element = Driver.FindElement(ColourChooser, Locators.ColourChoices);
            element.Click();
            return element;
        }

        public IWebElement DeselectFirstSelectedColour()
        {
            var families = ColourFamilyChooser.FindElements(Locators.ColourFamilyChoices);
            foreach (var family in families)
            {
                family.Click();
                if (ColourChooser.FindElements(Locators.SelectedColourBox).Any())
                {
                    var element = ColourChooser.FindElement(Locators.SelectedColourBox);
                    element.Click();
                    return element;
                }
            }
            return null;
        }



        public List<string> SelectedColours
        {
            get
            {
                var l = new List<string>();
                if (!FirstSelectedColour.Selected)
                {
                    return l;
                }
                l.Add(FirstSelectedColour.Name);
                if (!SecondSelectedColour.Selected)
                {
                    return l;
                }
                l.Add(SecondSelectedColour.Name);
                return l;
            }
        }

        public SelectedColour FirstSelectedColour
        {
            get { return new SelectedColour(TestSettings, Driver.FindElement(Container, Locators.FirstChoiceContainer)); }
        }

        public SelectedColour SecondSelectedColour
        {
            get { return new SelectedColour(TestSettings, Driver.FindElement(Container, Locators.SecondChoiceContainer)); }
        }


        public class Locators
        {
            public static readonly By Container = By.XPath("//div[contains(@class, 'try-on-step-wrap colour-selection-wrap')]");
            public static readonly By ColourFamilyChooser = By.XPath("//ul[@class='colour-family-selection']");
            public static readonly By ColourChooser = By.XPath("//*[@class='colour-selection-row']");
            public static readonly By FirstChoiceContainer = By.XPath("//div[contains(@class, 'colour-selected-panel first-selection')]");
            public static readonly By SecondChoiceContainer = By.XPath("//div[contains(@class, 'colour-selected-panel second-selection')]");
            public static readonly By SelectedColourFamilyBox = By.XPath("//li[@class='colour-family-item selected']/a");
            public static readonly By SelectedColourBox = By.XPath("//a[@class='colour-item-link darkColour selected']");
            public static readonly By ColourFamilyChoices = By.XPath("//a[@class='colour-family-link darkColour']");
            public static readonly By ColourChoices = By.XPath("//a[@class='colour-item-link darkColour']");
            public static readonly By ColourLimitReachedMessage = By.Id("maxColorSelectedMessage");
        }
    }
}
