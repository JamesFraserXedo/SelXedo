﻿using AlfredAngeloModel.Controls.Registration;
using CommonModel.Controls.Registration;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;

namespace AlfredAngeloModel.Pages
{
    public class RegistrationPage : PageBase
    {
        public RegistrationPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(BaseRegistrationForm.Locators.CompleteRegistrationButton);
        }

        public RegistrationForm Form
        {
            get { return new RegistrationForm(TestSettings); }
        }
    }
}
