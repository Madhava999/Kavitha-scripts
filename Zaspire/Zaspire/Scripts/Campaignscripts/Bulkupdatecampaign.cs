using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class Bulkupdatecampaign : DriverTestCase
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

            //Typetext  filter
            addcampaignHelper.TypeText("Filter", "Jobfair");
            addcampaignHelper.WaitForWorkAround(3000);

            //Click on Master Check box
            addcampaignHelper.ClickElement("Mastercheckbox");
            addcampaignHelper.WaitForWorkAround(3000);

            //Click on Bulk action
            addcampaignHelper.MouseOver("Locator");


            //Click on bulkupdate
            addcampaignHelper.ClickElement("Bulkupdate");
            addcampaignHelper.WaitForWorkAround(3000);

            //Select Status
            addcampaignHelper.Select("Status", "Active");

            //Select Category
            addcampaignHelper.Select("Category", "12526");

            //Select Type
            addcampaignHelper.Select("Type", "Webinar");

            //Select Owner
            addcampaignHelper.Select("Owner","17");

            //Select Maneger
            addcampaignHelper.Select("Manager","28");

            // Click on Updatebutton
            addcampaignHelper.ClickElement("update");











        }
    }
}