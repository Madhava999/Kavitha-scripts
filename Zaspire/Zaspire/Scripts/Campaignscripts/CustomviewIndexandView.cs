using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class CustomviewIndexandView : DriverTestCase
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
            addcampaignHelper.ClickElement("Customviews");

            //Click on view
            addcampaignHelper.ClickElement("CustomviewView");

            //Click on edit
            addcampaignHelper.ClickElement("EditCustomview");

            //Clcik on cancel
            addcampaignHelper.ClickElement("Cancelcustomviewedit");
        
            //Clcik on Set as default
            addcampaignHelper.ClickElement("SetasDefault");

            //Clcik on Unset as default
            addcampaignHelper.ClickElement("Unsetdefault");


            //Clcik on Delete
            addcampaignHelper.ClickElement("DeleteCustomView");
        }
    }
}
