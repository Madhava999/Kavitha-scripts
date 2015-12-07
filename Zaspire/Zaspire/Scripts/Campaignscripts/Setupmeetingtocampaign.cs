using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class Setupmeetingtocampaign : DriverTestCase
    {
        [TestMethod]
        public void Addcampaign()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addcampaignHelper = new CampaignHelper(GetWebDriver());

            //Variable

            var FirstName = "mortin" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var Campaigname = "Jobfair" + RandomNumber(1, 10);
            var Startdate = "2015-10-" + RandomNumber(1, 30);
            var Enddate = "2015-10-" + RandomNumber(1, 30);


            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addcampaignHelper.ClickElement("ClickCampaignsTab");

            //############### AddTask ################################################

            //Click On record
            addcampaignHelper.ClickElement("Clickonrecord");

            //Select Moreaction
            addcampaignHelper.ClickElement("Moreactions");

            //Select Add task
            addcampaignHelper.ClickElement("Setup Appointment");

            //Enter Status
            addcampaignHelper.Select("EventType", "Appointment");

            //Enter Category
            addcampaignHelper.TypeText("Location", "Secunderabad");

            //Enter a file
            addcampaignHelper.TypeText("Subject", "Add appointment");

            //Enter description
            addcampaignHelper.Select("StartDate", Startdate);

            //Click On record
            addcampaignHelper.ClickElement("starttime");


            //Select Moreaction
            addcampaignHelper.Select("EndDate", Enddate);

            //Select Add task
            addcampaignHelper.ClickElement("Endtime");

            //Enter Status
            addcampaignHelper.ClickElement("Reminders");

            //Select Category
            addcampaignHelper.Select("Popup", "1800");

            //Select a file
            addcampaignHelper.ClickElement("Email");

            //Select a file
            addcampaignHelper.Select("ReminderTime", "1800");

            //Click on Recurring  button
            addcampaignHelper.ClickElement("Recurring");

            // Select a file
            addcampaignHelper.Select("RepeteonceinEvery", "1");

            // Select Type
            addcampaignHelper.Select("RepeatType", "Monthly");

            //Click on Check box sunday
            //addcampaignHelper.ClickElement("WeekUI");

            //Select a file
            addcampaignHelper.ClickElement("OnRadiobutton");

            //Click on Recurring  button
            addcampaignHelper.ClickElement("Reportsofmonth");

            // Select a file
            addcampaignHelper.TypeText("Dateofthemonth", "2");

            //Enter description
            addcampaignHelper.ClickElement("OnRadiobutton");


            // Select a file
            addcampaignHelper.Select("Daytype", "First");

            //Enter description
            addcampaignHelper.Select("MonthDay", "2");


            //Select on Save button
            addcampaignHelper.Select("Until", "30/10/2015");

            //Select a file
            addcampaignHelper.Select("Inviteecontacts", "12");

            //Click on Recurring  button
            addcampaignHelper.TypeText("Email", "asd@gmail.com");

            // Select a file
            addcampaignHelper.TypeText("Firstname", FirstName);

            //Enter description
            addcampaignHelper.TypeText("Lastname ", LastName);


            // Select a file
            addcampaignHelper.ClickElement("Search");


            //Select Moreaction
            addcampaignHelper.ClickElement("Save");


        }
    }
}

