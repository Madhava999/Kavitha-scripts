using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class Viewcampaign : DriverTestCase
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

            //Click on record
            addcampaignHelper.ClickElement("Clickonrecord");

            //Click on timeline
            //addcampaignHelper.ClickElement("Timeline");

            //Clickon listview
            addcampaignHelper.ClickElement("Listview");

            //Clickon Graphicalview
            addcampaignHelper.ClickElement("Graphicalview");

            //Click on activitytab
            addcampaignHelper.ClickElement("activitytab");

            //Click on descriptiontab
            addcampaignHelper.ClickElement("descriptiontab");

            //Click on leadstab
            addcampaignHelper.ClickElement("leadstab");

            //Click on contacttab
            addcampaignHelper.ClickElement("contacttab");

            //Click on opportunitytab
            addcampaignHelper.ClickElement("opportunitytab");


            //Click on statisticstab
            addcampaignHelper.ClickElement("statisticstab");



        }
    }
}