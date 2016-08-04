using CommonModel.Controls.Common.Cookies;
using CommonModel.Controls.TidioChat;
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

        public HomePage HomePage
        {
            get { return new HomePage(GetTestSettings()); }
        }

        public Chatbox Chatbox
        {
            get { return new Chatbox(GetTestSettings()); }
        }

        public OrdersPage OrdersPage
        {
            get { return new OrdersPage(GetTestSettings()); }
        }

        public TryOnConfirmationPage TryOnConfirmationPage
        {
            get { return new TryOnConfirmationPage(GetTestSettings()); }
        }

        public PaymentPage PaymentPage
        {
            get { return new PaymentPage(GetTestSettings()); }
        }

        public TryOnReviewPage TryOnReviewPage
        {
            get { return new TryOnReviewPage(GetTestSettings()); }
        }

        public TryOnBasketPage TryOnBasketPage
        {
            get { return new TryOnBasketPage(GetTestSettings()); }
        }

        public CookiesDirective CookiesDirective
        {
            get { return new CookiesDirective(GetTestSettings()); }
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
