using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class GroupBulkupdateAndDelete : DriverTestCase
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
            addcampaignHelper.ClickElement("ViewGroup");
            
            //Enter  in Filter
            addcampaignHelper.ClickElement("Checkbox");
            
            //Moves over on bulkactions
            addcampaignHelper.MouseOver("GroupBulkAction");

            //Clcik on bulkupdate
            addcampaignHelper.ClickElement("GroupBulkUpdate");

            //Select Status
            addcampaignHelper.Select("Status", "Active");

            //Select Category
            addcampaignHelper.Select("Category", "12526");

            //Select Type
            addcampaignHelper.Select("Type", "Webinar");

            //Select Owner
            addcampaignHelper.Select("Owner", "17");

            //Select Maneger
            addcampaignHelper.Select("Manager", "28");

            // Click on Updatebutton
            addcampaignHelper.ClickElement("update");

        }

    }
}
