using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpTake.Page;

namespace UpTake.Tests
{
   [TestFixture]
   public class ApproachPageTest
   {
      public ApproachPage approachPage;
      public ChromeDriver driver;
      public const string URL = "http://www.uptake.com/approach";
      

      [OneTimeSetUp]
      public void SetupTest() {

         
         driver = new ChromeDriver(@"C:\Selenium");
         driver.Navigate().GoToUrl(URL);

         if(driver.Url.Contains("approach")) {

            approachPage = new ApproachPage(driver);
         }
      }

      [Test]

      public void DiffApproachLabelExists() {

         Assert.True(approachPage.DiffApproachLabel.Displayed, "There is no label displaying the different approach label");
      }

      [Test]

      public void DiffApproachLabelDisplaysCorrectText() {

         string text = "We take a different approach to data, the world’s most valuable asset.";

         Assert.True(approachPage.DiffApproachLabel.Text == text, "Label displays incorrect text.");
      }

      [OneTimeTearDown]

      public void TearTheTestsDown() {

         driver.Quit();
      }
   }
}
