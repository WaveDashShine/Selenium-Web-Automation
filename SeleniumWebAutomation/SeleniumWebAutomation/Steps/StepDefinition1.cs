﻿using TechTalk.SpecFlow;

namespace SeleniumWebAutomation.Steps
{
    [Binding]
    public sealed class StepDefinition1 : UtilityStep
    {   
        private readonly PageObject _google = new PageObject(Driver);
 
        [Given(@"I am on Google")]
        public void GivenIAmOnGoogle()
        {
            _google.GoToHomePage();
        }
    }
}
