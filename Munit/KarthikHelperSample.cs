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
    class KarthikHelperSample
    {

        IWebDriver driver;


        [Test]
        public void excel( )
        {

            //email = "san@gmail.com";
            //email1 = "samjhana@hotmail.com";
            //  string fileName = Environment.CurrentDirectory.ToString() + "\\data\\jdata.xlsx";
            string fileName = Environment.CurrentDirectory.ToString() + "\\TestData\\Data.xlsx";
            EHelperKarthik.PopulateInCollection(fileName);

           


            // CurrentPage = GetInstance<LoginPage>();
           // CurrentPage.As<LoginPage>().clickLogin(excelHelper.ReadData(1, "Username"), excelHelper.ReadData(1, "Password"));
            for (int i = 0; i < 5; i++)
            {


                driver = new ChromeDriver();


                driver.Navigate().GoToUrl("https://us.boohoo.com/register");
                driver.Manage().Window.Maximize();
             
                // last name 
                driver.FindElement(By.Id("dwfrm_profile_customer_firstname")).SendKeys(EHelperKarthik.ReadData(1,"Username"));

                //first name 
                driver.FindElement(By.Id("dwfrm_profile_customer_lastname")).SendKeys(EHelperKarthik.ReadData(1, "Password"));

                //Month
                SelectElement sel1 = new SelectElement(driver.FindElement(By.Id("dwfrm_profile_customer_monthofbirth")));
                sel1.SelectByIndex(1);
                //Day
                SelectElement sel2 = new SelectElement(driver.FindElement(By.Id("dwfrm_profile_customer_dayofbirth")));
                sel2.SelectByIndex(1);
                //year
                SelectElement sel3 = new SelectElement(driver.FindElement(By.Id("dwfrm_profile_customer_yearofbirth")));
                sel3.SelectByIndex(1);
                //excelHelper.ReadData(1, "Hello"), excelHelper.ReadData(1, "World"));


                driver.FindElement(By.Id("dwfrm_profile_customer_email")).SendKeys("abc@gmail.com");


                //confirmemail
                driver.FindElement(By.Id("dwfrm_profile_customer_emailconfirm")).SendKeys("bc@gmail.com");

                //confirm email
                //driver.FindElement(By.Id("dwfrm_profile_login_passwordconfirm_d0dyrkryiyrz")).SendKeys(email1);
                //driver.FindElement(By.Name("dwfrm_profile_confirm")).Click();
                driver.Navigate().Refresh();


            }

        }
    }
}

