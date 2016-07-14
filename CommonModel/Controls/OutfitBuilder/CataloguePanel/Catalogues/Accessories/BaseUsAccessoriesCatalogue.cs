﻿using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues.Accessories
{
    public abstract class BaseUsAccessoriesCatalogue : BaseCatalogue
    {
        protected BaseUsAccessoriesCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<Accessory> Shoes
        {
            get
            {
                var elements = Container.FindElements(Locators.Accessories);
                return elements.Select(e => new Accessory(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseCatalogue.Locators
        {
            public static By Accessories = By.ClassName("item accessory");
        }
    }
}