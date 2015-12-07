using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddGrouptocampaign : DriverTestCase
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

            var FirstName = "Campaign" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var Campaigname = "Candidates" + RandomNumber(1, 10);
            var Startdate = "2015-11-" + RandomNumber(1, 30);
            var Enddate = "2015-11-" + RandomNumber(1, 30);


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

            //Click on New button
            addcampaignHelper.ClickElement("newGroup");

            //enter groupname
            addcampaignHelper.TypeText("CampaignName", Campaigname);

            //Enter city
            addcampaignHelper.TypeText("GroupCity","Alowa");

            //Select state
            addcampaignHelper.Select("Groupstate", "AK");

            //Select country
            addcampaignHelper.Select("GroupCountry", "USA");

            //Enter Zipcode
            addcampaignHelper.TypeText("Groupzipcode", "123");

            //Click on Save button
            addcampaignHelper.ClickElement("Groupsave");
            
            



        }
    }
}