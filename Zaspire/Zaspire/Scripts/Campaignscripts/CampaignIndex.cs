using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class CampaignIndex : DriverTestCase
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

            //Select defaultview filter
            addcampaignHelper.Select("Defaultview", "Recently Added");
                
            //Select Custom filter
            addcampaignHelper.Select("Customviews", "24");
            
            //Select Group filter
            addcampaignHelper.Select("Filterbygroup", "16");
   
            //Typetext tag filter
            //addcampaignHelper.TypeText("Filterbytag", "asd");
            //addcampaignHelper.WaitForWorkAround(3000);
            
            //Typetext defaultview filter
            addcampaignHelper.ClickElement("Searchbutton");

            //Typetext defaultview filter
            addcampaignHelper.ClickElement("resettag");
            addcampaignHelper.WaitForWorkAround(3000);


            //Typetext defaultview filter
            addcampaignHelper.ClickElement("Filter");

            //Typetext defaultview filter
            addcampaignHelper.ClickElement("Reset");

            //Typetext defaultview filter
            addcampaignHelper.ClickElement("ExportCSV");

            //Typetext defaultview filter
            addcampaignHelper.ClickElement("ExportPDF");

            //Click on Record
            addcampaignHelper.ClickElement("Clickonrecord");

            //Click on Back 
            GetWebDriver().Navigate().GoToUrl("http://www.zaspire.com/infoaspire/campaigns");

            //Typetext defaultview filter
            addcampaignHelper.ClickElement("Import");

            //Click on Back
            GetWebDriver().Navigate().GoToUrl("http://www.zaspire.com/infoaspire/campaigns");
            
            //Typetext defaultview filter
            addcampaignHelper.ClickElement("Groups");


            //Click on Back
            GetWebDriver().Navigate().GoToUrl("http://www.zaspire.com/infoaspire/campaigns");

            //Typetext defaultview filter
            addcampaignHelper.ClickElement("Trash");


            //Click on Back 
            GetWebDriver().Navigate().GoToUrl("http://www.zaspire.com/infoaspire/campaigns");

        }
    }
}