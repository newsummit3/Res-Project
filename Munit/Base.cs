using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;

namespace Munit
{

    
public class Base
    {

        IWebDriver driver;
       
        public void SetUp(string browserName)
        {
            if (browserName.Equals("Chrome"))

                driver = new ChromeDriver();
            else if (browserName.Equals("FF"))
                driver = new FirefoxDriver();
            else if (browserName.Equals("edge"))
                driver = new EdgeDriver();
            else
                driver = new InternetExplorerDriver();

           
        }


        [TearDown]

        public void close()
        {
            driver.Close();
        }

        public static IEnumerable<String> BrowserToRunWith()
        {
            string[] browsers = { "Chrome", "FF" };

            foreach (String b in browsers)
            {
                yield return b;
            }
        }
    }


}
