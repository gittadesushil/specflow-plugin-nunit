using System;
using TechTalk.SpecFlow;

namespace Tests.NUnit
{
    [Binding]
    public class TestCodeGenerationSteps
    {
        [Given(@"a valid calculator")]
        public void GivenAValidCalculator()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
