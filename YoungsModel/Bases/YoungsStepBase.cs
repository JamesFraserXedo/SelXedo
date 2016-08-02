using Core.Contexts;
using Core.StepsSupport;
using YoungsModel.Controls.Common.Header;
using YoungsModel.Pages;

namespace YoungsModel.Bases
{
    public abstract class YoungsStepBase : StepBase
    {
        protected YoungsStepBase(Context context) : base(context)
        {
        }

        public ExclusiveAccessPage ExclusiveAccessPage
        {
            get { return new ExclusiveAccessPage(GetTestSettings()); }
        }

        public Header Header
        {
            get { return new Header(GetTestSettings()); }
        }

        public LoginSidebar LoginSidebar
        {
            get { return new LoginSidebar(GetTestSettings()); }
        }

        public RegistrationPage RegistrationPage
        {
            get { return new RegistrationPage(GetTestSettings()); }
        }

        public OutfitBuilderPage OutfitBuilderPage
        {
            get { return new OutfitBuilderPage(GetTestSettings()); }
        }

        public OutfitSummaryPage OutfitSummaryPage
        {
            get { return new OutfitSummaryPage(GetTestSettings()); }
        }
    }
}
