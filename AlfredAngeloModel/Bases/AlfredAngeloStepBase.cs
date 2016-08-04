using AlfredAngeloModel.Pages;
using Core.Contexts;
using Core.StepsSupport;

namespace AlfredAngeloModel.Bases
{
    public abstract class AlfredAngeloStepBase : StepBase
    {
        protected AlfredAngeloStepBase(Context context) : base(context)
        {
        }

        public HomePage HomePage
        {
            get { return new HomePage(GetTestSettings()); }
        }
    }
}
