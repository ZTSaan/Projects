
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTake.Page
{
   public class HomePage
   {
      public ChromeDriver Driver { get; private set; }
      

      public IWebElement ApproachBtn { get { return Driver.FindElement(By.Id("menu-item-4164")).FindElement(By.TagName("a")); } }

      public IWebElement PlatformBtn { get { return Driver.FindElement(By.Id("menu-item-4163")).FindElement(By.TagName("a")); } }
      public HomePage(ChromeDriver _driver) {

         Driver = _driver;
      }

      
      
   }
}
