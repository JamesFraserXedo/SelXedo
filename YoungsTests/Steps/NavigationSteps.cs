﻿using Core.Contexts;
using TechTalk.SpecFlow;
using YoungsModel.Bases;

namespace YoungsTests.Steps
{
    [Binding]
    public class NavigationSteps : YoungsStepBase
    {
        public NavigationSteps(Context context) : base(context)
        {
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            if (ExclusiveAccessPage.IsLoaded())
            {
                ExclusiveAccessPage.Login();
            }
            // HomePage.WaitUntilLoaded();
        }

        [Given(@"I am on the outfit builder")]
        public void GivenIAmOnTheOutfitBuilder()
        {
            Driver.Navigate().GoToUrl(BaseUrl + "OutfitBuilder/build");
            if (ExclusiveAccessPage.IsLoaded())
            {
                ExclusiveAccessPage.Login();
            }
            OutfitBuilderPage.WaitUntilLoaded();
        }
    }
}
