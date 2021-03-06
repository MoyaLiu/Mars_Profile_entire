﻿using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps
{
    [Binding]
    public sealed class ProfileDescription_Steps
    {
        ProfileDescription profileDescription = null;

        ProfileDescription_Steps()
        {
            profileDescription = new ProfileDescription();
        }

        [Given(@"Click description edit icon")]
        public void GivenClickDescriptionEditIcon()
        {
            profileDescription.ClickDescriptionWrtIcon();
        }
        //[Given(@"Enter the description")]
        //public void GivenEnterTheDescription(Table table)
        //{
        //    var description = table.Rows[0][0];
        //    Console.WriteLine("description = " + description + "length = " + description.Length);
        //    profileDescription.EnterDescription(description);
        //}
        [Given(@"Enter the description ""(.*)""")]
        public void GivenEnterTheDescription(string description)
        {
            profileDescription.EnterDescription(description);
        }

        [When(@"Click save button")]
        public void WhenClickSaveButton()
        {
            profileDescription.ClickSaveButton();
        }

        //[Then(@"The save successed dialog should be displayed")]
        //public void ThenTheSaveSuccessedDialogShouldBeDisplayed()
        //{
        //    Assert.AreEqual(profileDescription.successedText, profileDescription.getAlertDialogText());
        //}

        //[Then(@"The empty alert dialog should be displayed")]
        //public void ThenTheEmptyAlertDialogShouldBeDisplayed()
        //{
        //    Assert.AreEqual(profileDescription.emptyText, profileDescription.getAlertDialogText());
        //}

        //[Then(@"The invalid alert dialog should be displayed")]
        //public void ThenTheInvalidAlertDialogShouldBeDisplayed()
        //{
        //    Assert.AreEqual(profileDescription.invalidText, profileDescription.getAlertDialogText());
        //}

    }
}
