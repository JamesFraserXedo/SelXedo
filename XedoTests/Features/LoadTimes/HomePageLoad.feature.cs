﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace XedoTests.Features.LoadTimes
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Home Page Load Time", SourceFile="Features\\LoadTimes\\HomePageLoad.feature", SourceLine=0)]
    public partial class HomePageLoadTimeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HomePageLoad.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Home Page Load Time", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FirstTimeHomePageLoadsInGoodTime(string timeout, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("First time home page loads in good time", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I am on the outfit builder page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When("I go to the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then(string.Format("the page load time will be less than {0} seconds", timeout), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("First time home page loads in good time, Variant 0", SourceLine=10)]
        public virtual void FirstTimeHomePageLoadsInGoodTime_Variant0()
        {
            this.FirstTimeHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("First time home page loads in good time, Variant 1", SourceLine=10)]
        public virtual void FirstTimeHomePageLoadsInGoodTime_Variant1()
        {
            this.FirstTimeHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("First time home page loads in good time, Variant 2", SourceLine=10)]
        public virtual void FirstTimeHomePageLoadsInGoodTime_Variant2()
        {
            this.FirstTimeHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("First time home page loads in good time, Variant 3", SourceLine=10)]
        public virtual void FirstTimeHomePageLoadsInGoodTime_Variant3()
        {
            this.FirstTimeHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("First time home page loads in good time, Variant 4", SourceLine=10)]
        public virtual void FirstTimeHomePageLoadsInGoodTime_Variant4()
        {
            this.FirstTimeHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        public virtual void SubsequentHomePageLoadsInGoodTime(string timeout, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subsequent home page loads in good time", exampleTags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("I am on the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When("I go to the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then(string.Format("the page load time will be less than {0} seconds", timeout), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subsequent home page loads in good time, Variant 0", SourceLine=23)]
        public virtual void SubsequentHomePageLoadsInGoodTime_Variant0()
        {
            this.SubsequentHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subsequent home page loads in good time, Variant 1", SourceLine=23)]
        public virtual void SubsequentHomePageLoadsInGoodTime_Variant1()
        {
            this.SubsequentHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subsequent home page loads in good time, Variant 2", SourceLine=23)]
        public virtual void SubsequentHomePageLoadsInGoodTime_Variant2()
        {
            this.SubsequentHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subsequent home page loads in good time, Variant 3", SourceLine=23)]
        public virtual void SubsequentHomePageLoadsInGoodTime_Variant3()
        {
            this.SubsequentHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subsequent home page loads in good time, Variant 4", SourceLine=23)]
        public virtual void SubsequentHomePageLoadsInGoodTime_Variant4()
        {
            this.SubsequentHomePageLoadsInGoodTime("3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion