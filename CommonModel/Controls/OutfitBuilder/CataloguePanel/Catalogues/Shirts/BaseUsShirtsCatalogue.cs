﻿using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues.Shirts
{
    public abstract class BaseUsShirtsCatalogue : BaseCatalogue
    {
        protected BaseUsShirtsCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<Shirt> Shirts
        {
            get
            {
                var elements = Container.FindElements(Locators.Shirts);
                return elements.Select(e => new Shirt(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseCatalogue.Locators
        {
            public static By Shirts = By.ClassName("item shirt");
        }
    }
}