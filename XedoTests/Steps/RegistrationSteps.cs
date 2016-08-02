using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Contexts;
using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps
{
    [Binding]
    public class RegistrationSteps : XedoStepBase
    {
        public RegistrationSteps(Context context) : base(context)
        {
        }

        [Then(@"I am on the registration page")]
        public void ThenIAmOnTheRegistrationPage()
        {
            RegistrationPage.WaitUntilLoaded();
            Assert.That(RegistrationPage.IsLoaded);
        }

    }
}
