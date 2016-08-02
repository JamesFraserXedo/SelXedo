using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.BuildYourParty.PartyMemberInformation
{
    public class MemberDetailsForm : ControlBase
    {
        public MemberDetailsForm(TestSettings testSettings) : base(testSettings)
        {
        }

        public Checkbox AdultCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.AdultCheckbox)); }
        }

        public Checkbox ChildCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.ChildCheckbox)); }
        }

        public Selector RoleSelector
        {
            get { return new Selector(Driver.FindElement(Locators.RoleSelector)); }
        }

        public Inputbox FirstNameInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.FirstNameInputbox)); }
        }

        public Inputbox LastNameInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.LastNameInputbox)); }
        }

        public Inputbox EmailInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.EmailInputbox)); }
        }

        public Selector OutfitAssignSelector
        {
            get { return new Selector(Driver.FindElement(Locators.OutfitAssignSelector)); }
        }

        public Selector ManagedBySelector
        {
            get { return new Selector(Driver.FindElement(Locators.ManagedBySelector)); }
        }

        public class Locators
        {
            public static readonly By AdultCheckbox = By.Id("adult-radio");
            public static readonly By ChildCheckbox = By.Id("child-radio");
            public static readonly By RoleSelector = By.Id("EventRoleId");
            public static readonly By FirstNameInputbox = By.Id("Wearer_FirstName");
            public static readonly By LastNameInputbox = By.Id("Wearer_LastName");
            public static readonly By EmailInputbox = By.Id("Wearer_Email");
            public static readonly By OutfitAssignSelector = By.Id("WearerOutfit_OutfitId");
            public static readonly By ManagedBySelector = By.CssSelector("[data-at='ddl-child-managed-by']");
        }
    }
}
