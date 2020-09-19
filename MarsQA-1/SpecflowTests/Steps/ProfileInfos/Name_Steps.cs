using MarsQA_1.SpecflowPages.Pages.ProfileInfos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps.ProfileInfos
{
    [Binding]
    public sealed class Name_Steps
    {
        Name name = null;

        Name_Steps()
        {
            name = new Name();
        }

        [Given(@"Click Name")]
        public void GivenClickName()
        {
            name.ClickName();
        }

        [Given(@"Enter values in ""(.*)"" and ""(.*)""")]
        public void GivenEnterValuesInAnd(string firstName, string lastName)
        {
            Console.WriteLine("firstName = " + firstName);
            Console.WriteLine("lastName = " + lastName);
            name.EditName(firstName, lastName);
        }

        [When(@"Click Save")]
        public void WhenClickSave()
        {
            name.SaveName();
        }

        [Then(@"The name is display as ""(.*)""""(.*)""")]
        public void ThenTheNameIsDisplayAs(string firstName, string lastName)
        {
            Assert.AreEqual(firstName + " " + lastName, name.getName());
        }
    }
}
