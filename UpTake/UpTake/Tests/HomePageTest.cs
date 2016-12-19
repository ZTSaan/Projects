using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpTake.Page;
using NUnit;

namespace UpTake.Tests
{
   [TestFixture]
   public class HomePageTest
   {

      public const string URL = "http://www.uptake.com";
      public HomePage homePage;
      public ChromeDriver driver;

      [OneTimeSetUp]

      public void SetUp() {

        driver = new ChromeDriver(@"C:\Selenium");

         homePage = new HomePage(driver);

         driver.Navigate().GoToUrl(URL);

         

      }

      [Test]

      public void CanNavigateToApproachPage() {

         homePage.ApproachBtn.Click();

         Assert.True(homePage.Driver.Url.Contains("approach"), "Approach hyperlink navigates to the wrong page.");
      }

      [Test]

      public void CanNavigateToPlatformPage() {

         homePage.PlatformBtn.Click();

         Assert.True(homePage.Driver.Url.Contains("platform"), "Platform hyperlink navigates to wrong page.");
      }

      [OneTimeTearDown]

      public void TearTheTestDown() {

         driver.Quit();
      }
   }
}
