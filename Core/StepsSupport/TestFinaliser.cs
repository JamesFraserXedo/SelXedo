﻿using System;
using Core.Contexts;
using Core.Model.SupportTools;
using Core.Utilities;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Core.StepsSupport
{
    public class TestFinaliser : StepBase
    {
        public TestFinaliser(Context context) : base(context)
        {
        }

        public static void TearDown()
        {
            switch (WebDriverFactory.GetTestExecutionEnvironment())
            {
                case WebDriverFactory.TestExecutionEnvironment.Local:
                    LocalTearDown();
                    break;
                    
                case WebDriverFactory.TestExecutionEnvironment.Grid:
                    GridTearDown();
                    break;
                     
                case WebDriverFactory.TestExecutionEnvironment.Saucelabs:
                    SaucelabsTearDown();
                    break;
                default:
                    throw new ArgumentException("Could not tear down the session for this execution environment");
            }
        }

        private static void LocalTearDown()
        {
            QuitDriver();
        }

        private static void QuitDriver()
        {
            if (!DidTestPass())
            {
                if (Driver.GetType() == typeof (CustomDriver))
                {
                    Console.WriteLine("{0}Session ID: {0}{1}", Environment.NewLine, ((CustomDriver)Driver).SessionId);
                }
                Console.WriteLine("{0}Final URL: {0}{1}", Environment.NewLine, Driver.Url);
                TakeScreenshot();
            }
            if (Driver != null)
            {
                Driver.Quit();
            }
            Driver = null;
        }

        private static void SaucelabsTearDown()
        {
            Utils.IJavaScriptExecutor(Driver).ExecuteScript("sauce:job-result=" + (DidTestPass() ? "passed" : "failed"));
            QuitDriver();
        }

        private static void GridTearDown()
        {
            QuitDriver();
        }

        private static bool DidTestPass()
        {
            return ScenarioContext.Current.TestError == null;
        }

        private static void TakeScreenshot()
        {
            ScreenshotCreator.CreateErrorScreenshot(Driver);
        }
    }
}
