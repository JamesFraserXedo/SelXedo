using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;

namespace CommonModel.Controls.HomePage.ColourMatch
{
    public class UsColourMatch : BaseColourMatch
    {
        public UsColourMatch(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public Button Gray
        {
            get { return new Button(Driver.FindElement(Container, Locators.Gray)); }
        }
    }
}
