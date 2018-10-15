using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Munit
{
    class Class2
    {
        IWebDriver driver;


        [OneTimeSetUp]

        public void init()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://us.boohoo.com/register");
            driver.Manage().Window.Maximize();

        }

        [Test, TestCaseSource("registerData")]

        public void pageRefresh(String user, String pass, string email, string email1)
        {
            for (int i = 0; i < 2; i++)
            {

                //Console.WriteLine(user + "--", "--" + pass + "--" + email + "--" + email1 + "--");
                // last name 
                driver.FindElement(By.Id("dwfrm_profile_customer_firstname")).SendKeys(user);

            //first name 
            driver.FindElement(By.Id("dwfrm_profile_customer_lastname")).SendKeys(pass);

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


            driver.FindElement(By.Id("dwfrm_profile_customer_email")).SendKeys(email);


            //confirmemail
            driver.FindElement(By.Id("dwfrm_profile_customer_emailconfirm")).SendKeys(email1);

            //confirm email
            //driver.FindElement(By.Id("dwfrm_profile_login_passwordconfirm_d0dyrkryiyrz")).SendKeys(email1);
            //driver.FindElement(By.Name("dwfrm_profile_confirm")).Click();
            // driver.Close();
            driver.Navigate().Refresh();

                // Thread.Sleep(5000);
                break;

            }

           // 
            Console.WriteLine("hurray");
        }


        public static Object[][] registerData()
        {
            // object[][] data = new Object[9][];

            object[][] data = new Object[3][];
            //row is how any times test  to b executed
            //column are how many parameters 
            data[0] = new object[4];
            data[0][0] = "mercury";
            data[0][1] = "mercury";
            data[0][2] = "sanjeev@gmail.com";
            data[0][3] = "sanj@hotmail.com";


            data[1] = new object[4];
            data[1][0] = "mercury";
            data[1][1] = "mercury";
            data[1][2] = "Kiew@gmail.com";
            data[1][3] = "Jay@hotmail.com";


            data[2] = new object[4];
            data[2][0] = "mercury";
            data[2][1] = "mercury";
            data[2][2] = "sanv@gmail.com";
            data[2][3] = "praveen@hotmail.com";

            //data[3] = new object[4];
            //data[3][0] = "mercury";
            //data[3][1] = "mercury";
            //data[3][2] = "James@gmail.com";
            //data[3][3] = "Jane@hotmail.com";

            //data[4] = new object[4];
            //data[4][0] = "mercury";
            //data[4][1] = "mercury";
            //data[4][2] = "sanvi@gmail.com";
            //data[4][3] = "pramesh@hotmail.com";

            //data[5] = new object[4];
            //data[5][0] = "mercury";
            //data[5][1] = "mercury";
            //data[5][2] = "sanam@gmail.com";
            //data[5][3] = "simala@hotmail.com";



            //data[6] = new object[4];
            //data[6][0] = "mercury";
            //data[6][1] = "mercury";
            //data[6][2] = "zorrro@gmail.com";
            //data[6][3] = "pravat@hotmail.com";


            //data[7] = new object[4];
            //data[7][0] = "mercury";
            //data[7][1] = "mercury";
            //data[7][2] = "mahesh@gmail.com";
            //data[7][3] = "pravat@hotmail.com";


            //data[8] = new object[4];
            //data[8][0] = "mercury";
            //data[8][1] = "mercury";
            //data[8][2] = "siva@gmail.com";
            //data[8][3] = "pravat@hotmail.com";


            return data;
        }
        [OneTimeTearDown]
        public void tearDown()
        {
            driver.Close();
        }

    }
}


      
 