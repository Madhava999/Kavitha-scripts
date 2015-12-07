using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddLeadstocampaign : DriverTestCase
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
           
           

            //################################# CREATE A Campaign  #############################################

            //Click On Create
            addcampaignHelper.ClickElement("ClickOnCreate");

            //Select Status
            addcampaignHelper.Select("Status", "Active");

            //Select Category
            addcampaignHelper.Select("Category", "20678");

            //Select Owner
            addcampaignHelper.Select("Owner", "51");

            //Select Manager 
            addcampaignHelper.Select("Maneger", "51");

            //Enter Campaignname
            addcampaignHelper.TypeText("Campaignname", Campaigname);

            //Select Startdate
            addcampaignHelper.TypeText("Startdate", Startdate);

            //Select Enddate
            addcampaignHelper.TypeText("Enddate", Enddate);

            //Select Campaigntype
            addcampaignHelper.Select("Campaigntype", "Partners");

            //Enter Estimatedcost
            addcampaignHelper.TypeText("Expectedcost", "1000");

            //Enter Targetednum
            addcampaignHelper.TypeText("Targetednum", "100");

            //Enter Actualcost
            addcampaignHelper.TypeText("Actualcost", "150");

            //Enter Expectedresponse
            addcampaignHelper.TypeText("Expectedresponse", "100");

            //Enter Expectedrevenue
            addcampaignHelper.TypeText("Expectedrevenue", "150");

            //Enter Campaignurl
            addcampaignHelper.TypeText("Campaignurl", "http://zaspire.com/infoaspire/campaigns");

            //Click on save button
            addcampaignHelper.ClickElement("Save");


            //AddLead to campaign
                
             //Clcick on Record view 
            addcampaignHelper.ClickElement("Clickonrecord");

            //Click on moreAction
            addcampaignHelper.ClickElement("Moreaction");

            //selectAdd Lead 
            addcampaignHelper.ClickElement("Add Lead");

            //Select Result per page
            addcampaignHelper.Select("Resultperpage", "20");


            //Click on master checkbox
            addcampaignHelper.ClickElement("Master checkbox");

            //Click on Add Compaign
            addcampaignHelper.ClickElement("Add to Campaigns");






    

        }
    }
}


