using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps
{
    [Binding]
    public sealed class ProfileInfo_Steps
    {
        ProfileInfo profileInfo = null;

        ProfileInfo_Steps()
        {
            profileInfo = new ProfileInfo();
        }

        //Name part
        [Given(@"Click Name")]
        public void GivenClickName()
        {
            profileInfo.ClickName();
        }

        //[Given(@"Enter values in First Name and Last Name")]
        //public void GivenEnterValuesInFirstNameAndLastName(Table table)
        //{
        //    var firstName = table.Rows[0][0];
        //    var lastName = table.Rows[0][1];
        //    profileInfo.EditName(firstName, lastName);
        //    Console.WriteLine("Table 1 = " + firstName);
        //    Console.WriteLine("Table 2 = " + lastName);
        //}
        [Given(@"Enter values in ""(.*)"" and ""(.*)""")]
        public void GivenEnterValuesInAnd(string firstName, string lastName)
        {
            Console.WriteLine("firstName = " + firstName);
            Console.WriteLine("lastName = " + lastName);
            profileInfo.EditName(firstName, lastName);
        }

        //[Given(@"Enter values in ""(.*)"" and ""(.*)""")]
        //public void GivenEnterValuesInAnd(string p0, string p1, Table table)
        //{
        //    Console.WriteLine("po = " + p0);
        //    Console.WriteLine("P1 = " + p1);
        //}

        //[When(@"Click ""(.*)""")]
        //public void WhenClick(string p0)
        //{
        //    profileInfo.SaveName();
        //}
        [When(@"Click Save")]
        public void WhenClickSave()
        {
            profileInfo.SaveName();
        }

        [Then(@"The name is display as ""(.*)""""(.*)""")]
        public void ThenTheNameIsDisplayAs(string firstName, string lastName)
        {
            Assert.AreEqual(firstName + " " + lastName, profileInfo.getName());
        }

        //Availability part
        [Given(@"Click availability edit icon")]
        public void GivenClickAvailabilityEditIcon()
        {
            profileInfo.ClickTimeTypeWriteIcon();
        }

        [When(@"Choose the availability ""(.*)""")]
        public void WhenChooseTheAvailability(string timeType)
        {
            Console.WriteLine("timeType = " + timeType);
            profileInfo.ChooseTimeType(timeType);
        }

        [Then(@"The availability should be update as ""(.*)""")]
        public void ThenTheAvailabilityShouldBeUpdateAs(string timeType)
        {
            Console.WriteLine("timeType = " + timeType);
            Assert.AreEqual(timeType, profileInfo.getTimeTypeText());
        }




    }
}
