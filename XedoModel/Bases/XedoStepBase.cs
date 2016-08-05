using CommonModel.Controls.CollectionsPage;
using Core.Contexts;
using Core.StepsSupport;
using TechTalk.SpecFlow;
using XedoModel.Controls.Common.Footer;
using XedoModel.Controls.Common.Header;
using XedoModel.Pages;

namespace XedoModel.Bases
{
    [Binding]
    public abstract class XedoStepBase : StepBase
    {
        protected XedoStepBase(Context context) : base(context)
        {
        }

        public CollectionProductDetails CollectionProductDetails
        {
            get { return new CollectionProductDetails(GetTestSettings()); }
        }
        public HomePage HomePage
        {
            get { return new HomePage(GetTestSettings()); }
        }

        public ExclusiveAccessPage ExclusiveAccessPage
        {
            get { return new ExclusiveAccessPage(GetTestSettings()); }
        }

        public static OutfitBuilderPage OutfitBuilderPage
        {
            get { return new OutfitBuilderPage(GetTestSettings()); }   
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

    }
}
