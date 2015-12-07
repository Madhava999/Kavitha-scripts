using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;
using OpenQA.Selenium;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddParntners : DriverTestCase
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

            //Variable

            var FirstName = "mark" + RandomNumber(1, 99);
            var LastName = "master" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var Partnername = "Partner" + RandomNumber(1, 20);
            var Companyname = "Company" + RandomNumber(1, 10);
            var Startdate = "2015-12-" + RandomNumber(1, 30);
            var Enddate = "2015-12-" + RandomNumber(1, 30);


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
            addpartnerHelper.ClickElement("partnerAddNew");

            //Select owner
            addpartnerHelper.Select("Owner", "17");

            //Select manger
            addpartnerHelper.Select("Manager", "19");

            //Enter Partnername
            addpartnerHelper.TypeText("PartnerName", Partnername);

            //Enter Partnercompany name 
            addpartnerHelper.TypeText("PartnerCompany", Companyname);

            //Enter Partner website
            addpartnerHelper.TypeText("PartnerWebsite", "www.partners.com");

            //Enter Partnercode
            addpartnerHelper.TypeText("PartnerCode", "1234");

            //Enter LinkedUrl
            addpartnerHelper.TypeText("LinkedinUrl", "www.link.com");

            //Enter Facebook Url
            addpartnerHelper.TypeText("facebookUrl", "www.facebook.com");

            //Enter Twitter Url
            addpartnerHelper.TypeText("TwitterUrl", "www.twitter.com");

            //Select Adress type
            addpartnerHelper.Select("AddressType", "Location");

            //Enter Adressline1
            addpartnerHelper.TypeText("AddressLine1", "Lane1");

            //Enter Adressline2
            addpartnerHelper.TypeText("AddressLine2", "Road no2");

            //Enter city
            addpartnerHelper.TypeText("City", "Aloka");

            //Select state
            addpartnerHelper.Select("State", "AL");

            //Select Country
            addpartnerHelper.Select("Country", "USA");

            //Enter Zipcode
            addpartnerHelper.TypeText("Zipcode", "2345");

            //Select Salutation
            addpartnerHelper.Select("Salutation", "Mr");

            //Enter First name
            addpartnerHelper.TypeText("FirstName", FirstName);

            //Enter middlename
            addpartnerHelper.TypeText("MiddleName", "kumar");

            //Enter Lastname
            addpartnerHelper.TypeText("LastName", LastName);

            //Select Phonetype
            addpartnerHelper.Select("PhoneType", "Cell");

            //Enter PhoneFormat
            addpartnerHelper.TypeText("PhoneFormat", "1234567890");

            //Click elecment Primaryradiobutton
            addpartnerHelper.ClickElement("Primaryradiobutton");

            //Click on Checkbox
            addpartnerHelper.ClickElement("Checkbox");

            //Select Email Type
            addpartnerHelper.Select("Email", "Home");

            //Enter EmailId
            addpartnerHelper.TypeText("EmailId", "sss@gmail.com");

            //Click on Primaryradiobutton
            addpartnerHelper.ClickElement("Primaryradiobutton");

            //Click on OptOut
            addpartnerHelper.ClickElement("OptOut");

            //Select social type
            addpartnerHelper.Select("SocialLinkType", "Facebook");

            //Enter SocialLink
            addpartnerHelper.TypeText("SocialLink", "aaa@gmail.com");

            //Clickon Optedout
            addpartnerHelper.ClickElement("optedout");

            //Click on save button
            addpartnerHelper.ClickElement("save");
        }
    }
}





            
