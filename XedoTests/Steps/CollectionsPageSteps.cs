using Core.Contexts;
using Core.Model.SupportTools;
using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoModel.Bases;
using XedoModel.Pages;

namespace XedoTests.Steps
{
    [Binding]
    public class CollectionsPageSteps : XedoStepBase
    {
        public CollectionsPageSteps(Context context) : base(context)
        {
        }

        [Then(@"I should be taken to the collections page")]
        public void ThenIShouldBeTakenToTheCollectionsPage()
        {
            Assert.That(Driver.ElementExists(CollectionsPage.Locators.Identifier));
        }

        [Then(@"a product details popup should appear")]
        public void ThenAProductDetailsPopupShouldAppear()
        {
            Assert.That(CollectionProductDetails.Container.Displayed);
        }

        [Then(@"the product details should display the correct image")]
        public void ThenTheProductDetailsShouldDisplayTheCollectionImage()
        {
            Assert.That(CollectionProductDetails.ImageElement.Displayed);
            Assert.AreNotEqual(CollectionProductDetails.ImageElement.GetAttribute("src"), "");
        }

        [Then(@"the product details should display the correct name")]
        public void ThenTheProductDetailsShouldShowTheCorrectName()
        {
            Assert.AreEqual(CollectionProductDetails.Name.ToLower(), Context.Collection.Name.ToLower());
        }

        [Then(@"the product details should display the correct price")]
        public void ThenTheProductDetailsShouldShowTheCorrectPrice()
        {
            Assert.AreEqual(CollectionProductDetails.Price, Context.Collection.Price);
        }
    }
}
