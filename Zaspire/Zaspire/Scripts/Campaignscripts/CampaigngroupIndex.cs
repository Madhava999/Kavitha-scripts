using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddcampaignGroupIndex : DriverTestCase
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

            //Click on Index
            addcampaignHelper.ClickElement("FilterGroups");

            //Enter  in Filter
            addcampaignHelper.TypeText("groupsfilter", "new");

            //Clickon Reset
            addcampaignHelper.ClickElement("groupsReset");

            //Clickon Checkbox
            addcampaignHelper.ClickElement("groupMasterbox");


            //Click on Bulk action
            addcampaignHelper.MouseOver("Locator");
            addcampaignHelper.AcceptAlert();
            addcampaignHelper.WaitForWorkAround(3000);

            //Click on bulkupdate
            addcampaignHelper.ClickElement("DeletecampaignGroup");

            addcampaignHelper.AcceptAlert();
            addcampaignHelper.WaitForWorkAround(5000);




        }
    }
}