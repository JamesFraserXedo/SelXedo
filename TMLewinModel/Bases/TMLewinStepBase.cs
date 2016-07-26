using Core.Contexts;
using Core.StepsSupport;
using TechTalk.SpecFlow;
using TMLewinModel.Controls.Common.Footer;
using TMLewinModel.Controls.Common.Header;
using TMLewinModel.Pages;

namespace TMLewinModel.Bases
{
    [Binding]
    public abstract class TMLewinStepBase : StepBase
    {
        protected TMLewinStepBase(Context context) : base(context)
        {
        }

        public static ExclusiveAccessPage ExclusiveAccessPage
        {
            get { return new ExclusiveAccessPage(GetTestSettings()); }
        }

        public static HomePage HomePage
        {
            get { return new HomePage(GetTestSettings()); }
        }

        public static Header Header
        {
            get { return new Header(GetTestSettings()); }
        }

        public static Footer Footer
        {
            get { return new Footer(GetTestSettings()); }
        }

        public static RegistrationPage RegistrationPage
        {
            get { return new RegistrationPage(GetTestSettings()); }
        }

        public static TryOnPaymentPage TryOnPaymentPage
        {
            get { return new TryOnPaymentPage(GetTestSettings()); }
        }
    }
}
