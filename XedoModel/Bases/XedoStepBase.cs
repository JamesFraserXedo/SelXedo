using Core.Contexts;
using Core.StepsSupport;
using TechTalk.SpecFlow;
using XedoModel.Controls.Common;
using XedoModel.Controls.Common.Footer;
using XedoModel.Controls.Common.Header;
using XedoModel.Pages;
using XedoModel.Pages.PaymentProcess;

namespace XedoModel.Bases
{
    [Binding]
    public abstract class XedoStepBase : StepBase
    {
        protected XedoStepBase(Context context) : base(context)
        {
        }
        
        public static OutfitSummaryPage OutfitSummaryPage
        {
            get { return new OutfitSummaryPage(GetTestSettings()); }
        }

        public static RegistrationPage RegistrationPage
        {
            get { return new RegistrationPage(GetTestSettings()); }
        }

        public static Header Header
        {
            get { return new Header(GetTestSettings()); }
        }

        public static Footer Footer
        {
            get { return new Footer(GetTestSettings()); }
        }

        public static LoginSidebar LoginSidebar
        {
            get { return new LoginSidebar(GetTestSettings()); }
        }
        
        public static SelectWeddingDatePage SelectWeddingDatePage
        {
            get { return new SelectWeddingDatePage(GetTestSettings()); }
        }

        public static BuildPartyPage BuildPartyPage
        {
            get { return new BuildPartyPage(GetTestSettings()); }
        }

        public static BillingAddressPage BillingAddressPage
        {
            get { return new BillingAddressPage(GetTestSettings()); }
        }

        public static PaymentOptionsPage PaymentOptionsPage
        {
            get { return new PaymentOptionsPage(GetTestSettings()); }
        }
    }
}
