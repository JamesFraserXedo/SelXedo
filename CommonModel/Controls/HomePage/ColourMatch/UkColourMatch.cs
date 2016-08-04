using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;

namespace CommonModel.Controls.HomePage.ColourMatch
{
    public class UkColourMatch : BaseColourMatch
    {
        public UkColourMatch(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public Button Grey
        {
            get { return new Button(Driver.FindElement(Container, Locators.Gray)); }
        }
    }
}
