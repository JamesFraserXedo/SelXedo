using Core.Contexts;
using Core.StepsSupport;
using PromGuyModel.Pages;

namespace PromGuyModel.Bases
{
    public abstract class PromGuyStepBase : StepBase
    {
        protected PromGuyStepBase(Context context) : base(context)
        {
        }

        public HomePage HomePage
        {
            get { return new HomePage(GetTestSettings()); }
        }
    }
}
