using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munit
{

    [TestFixture]
    public class DropdownClass
    {

        IWebDriver driver;

        [OneTimeSetUp]

        public void init()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.expedia.com");
            driver.Manage().Window.Maximize();

        }

        [Test]

        public void dropdown()
        {
            SelectElement select = new SelectElement(driver.FindElement(By.Id("package-1-children-hp-package")));

            select.SelectByIndex(1);

            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("package-1-age-select-1-hp-package")));

            IList<IWebElement> lsit = driver.FindElements(By.TagName("option"));
          for (int i=0; i<lsit.Count; i++)
            {
             if(lsit[i].Text.Equals("1"))
                {
                    lsit[i].Click();

                    Console.WriteLine("it got clicked");
                }
                else
                {
                    new StaleElementReferenceException();
                }
            }










        }
    }
}