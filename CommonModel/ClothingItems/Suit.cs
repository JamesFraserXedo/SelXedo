using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.ClothingItems
{
    public class Suit : ClothingBase
    {
        public Suit(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
        
        public bool HasPocket
        {
            get { return DetailsElement.GetAttribute("data-jacket-haspocket").ToLower() == "true"; }
        }
        
        public string TrousersImagePath
        {
            get { return DetailsElement.GetAttribute("data-trousers-preview"); }
        }
    }
}
