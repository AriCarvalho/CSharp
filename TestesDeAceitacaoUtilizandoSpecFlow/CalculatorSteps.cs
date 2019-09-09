using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TestesDeAceitacaoUtilizandoSpecFlow
{
    [Binding]
    public class CalculatorSteps
    {
        //Criar Classe
        private int x;
        private int y;
        private int z;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            x = p0;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            y = p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            z = x + y;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
           Assert.AreEqual(p0, z);
           // ScenarioContext.Current.Pending();
        }
    }
}
