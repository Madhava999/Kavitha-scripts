using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class ParntnerIndex : DriverTestCase
    {
        [TestMethod]
        public void AddNewPartner()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var addpartnerHelper = new PartnerHelper(GetWebDriver());

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Dashboard in menu
            addpartnerHelper.ClickElement("partners");


            //#########################Create Partner######################################

            //Click On Create
            addpartnerHelper.Select("DefaultView", "Recently Added");
               
            //Select owner
            addpartnerHelper.Select("CustomView", "30");
     

            //Enter text in filter
            addpartnerHelper.TypeText("Filter", "Partner");

            //Clic on PartnerFilter Reset
            addpartnerHelper.ClickElement("Reset");

            
            //Enter Partner export
            addpartnerHelper.ClickElement("ExportCSV");
            addpartnerHelper.WaitForWorkAround(1000);


            //Redirect to logout
            GetWebDriver().Navigate().GoToUrl("http://www.zaspire.com/infoaspire/partners");

            //Enter Partner export
            addpartnerHelper.ClickElement("ExportPDF");
            addpartnerHelper.WaitForWorkAround(1000);

            //Redirect to logout
            GetWebDriver().Navigate().GoToUrl("http://www.zaspire.com/infoaspire/partners");

            // Enter Partner website
            addpartnerHelper.Select("Recordsperpage","20");

            // Enter Partner website
            addpartnerHelper.ClickElement("PartnerView");
        }
    }
}

