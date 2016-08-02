using System;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public abstract class ClothingBase : ControlBase
    {
        protected IWebElement _container;
        protected ClothingBase(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }
        
        public abstract string Name { get; }

        public abstract string Id { get; }

        public abstract bool Selected { get; }

        public abstract void Select();

        public abstract void Deselect();
    }
}
