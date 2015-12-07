using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddTasktocampaign : DriverTestCase
    {
        [TestMethod]
        public void AddFilecampaign()
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

            var FirstName = "Test" + RandomNumber(1, 99);
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
            addcampaignHelper.ClickElement("Addtask");

            //Enter Status
            addcampaignHelper.Select("EventType", "Task");

            //Enter Category
            addcampaignHelper.TypeText("Location", "Secunderabad");

            //Enter a file
            addcampaignHelper.TypeText("Subject","Add Task");
             
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
            addcampaignHelper.Select("Popup", "900");

            //Select a file
            addcampaignHelper.ClickElement("Email");
            
            //Select a file
            addcampaignHelper.Select("ReminderTime", "900");
            
            //Click on Recurring  button
            addcampaignHelper.ClickElement("Recurring");
            
            // Select a file
            addcampaignHelper.Select("RepeteonceinEvery", "1");
            
            // Select Type
            addcampaignHelper.Select("RepeatType", "Weekly");

            //Click on Check box sunday
            addcampaignHelper.ClickElement("WeekUI");

            /*Select a file
            //.ClickElement("OnRadiobutton");

            //Click on Recurring  button
            //addcampaignHelper.ClickElement("Reportsofmonth");

            // Select a file
            addcampaignHelper.ClickElement("Dateofthemonth");

            //Enter description
            addcampaignHelper.TypeText("OnRadiobutton", "This is a file to campaign");


            // Select a file
            addcampaignHelper.ClickElement("Daytype");

            //Enter description
            addcampaignHelper.TypeText("MonthDay", "This is a file to campaign");*/


            //Select on Save button
            addcampaignHelper.Select("Until", "30/10/2015");

            //Select Moreaction
            addcampaignHelper.ClickElement("Save");

           
        }
    }
}