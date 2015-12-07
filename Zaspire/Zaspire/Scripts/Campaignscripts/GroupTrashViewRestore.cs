using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class GroupTrashviewRestore : DriverTestCase
    {
        [TestMethod]
        public void CampaignTrash()
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
            addcampaignHelper.ClickElement("ClickCampaigns Tab");


            //######################### Group Trash record restore r######################################

            //Click On trash
            //addcampaignHelper.ClickElement("Trash");
            
            //Redirect to logout
            GetWebDriver().Navigate().GoToUrl("http://www.zaspire.com/infoaspire/campaigns/groups/view/3");


            //Click onrecord
            addcampaignHelper.ClickElement("GroupRecordview");

            //Click on opportunitytab
            addcampaignHelper.ClickElement("restoreGrouprecord");




        }
    }
}
