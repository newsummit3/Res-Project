using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Munit
{


    [TestFixture]
   // [Parallelizable]
    public class Class3 : Base

    {
        IWebDriver driver;

      

        [Test]
        [TestCaseSource(typeof(Base), "BrowserToRunWith")]
 public void Verifytest(string browserName)
        {
            SetUp(browserName);
             driver.Navigate().GoToUrl("http://beingzero.in/selenium-login-form");
         //  driver.Navigate().GoToUrl(url);
            //Console.WriteLine(user + "--", "--" + pass + "--" + email + "--" + email1 + "--");
            driver.FindElement(By.Id("dwfrm_profile_customer_firstname")).SendKeys("mercury");

            //first name 
            driver.FindElement(By.Id("dwfrm_profile_customer_lastname")).SendKeys("Mercury");

            //Month



            driver.FindElement(By.Id("dwfrm_profile_customer_email")).SendKeys("abc@gmail.com");


            //confirmemail
            driver.FindElement(By.Id("dwfrm_profile_customer_emailconfirm")).SendKeys("sanjeev@gmail.com");

            //confirm email
            //driver.FindElement(By.Id("dwfrm_profile_login_passwordconfirm_d0dyrkryiyrz")).SendKeys(email1);
            //driver.FindElement(By.Name("dwfrm_profile_confirm")).Click();
            // driver.Close();
            driver.Navigate().Refresh();
            driver.Close();
        }

    


        [Test]
        [TestCaseSource(typeof(Base), "BrowserToRunWith")]

        public void Verifytest1(string browserName, string user, string pass)
        { user = "Mercury";
            pass = "mercury";

            string url = "https://us.boohoo.com/register";
            SetUp(browserName);

            driver.Navigate().GoToUrl(url);


            driver.FindElement(By.Name("userName")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pass);

        }

    }
}
     
    