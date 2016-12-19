using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UpTake.Page
{
   public class ApproachPage
   {
      public ChromeDriver Driver { get; private set; }

      public IWebElement DiffApproachLabel { get { return Driver.FindElement(By.XPath("//*[@id='whynow']/div/h2")); } }

      public ApproachPage(ChromeDriver _driver) {

         Driver = _driver;
      }
   }
}
