using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.PageObjects;



using System;

using excel = Microsoft.Office.Interop.Excel;
namespace Munit
{
    class excelUtility
    {


        [Test]

        public void LoginTest()

        {

            //Creates excel application

            excel.Application x1Appl = new excel.Application();



            //Creates excel workbook object for specified file

            excel.Workbook x1WorkBook = x1Appl.Workbooks.Open(@"C:\Users\sanjeev\source\repos\Nunit\Munit\TestData\Data.xlsx");



            //Creates excel work sheet object for sheet 1

            excel._Worksheet x1WorkSheet = x1WorkBook.Sheets[1];



            //Gets used range of excel file(here range is 3)

            excel.Range x1Range = x1WorkSheet.UsedRange;



            int xlRowCnt = 0;

            String Username;

            String Password;

          //  String Role;



            for (xlRowCnt = 2; xlRowCnt <= x1Range.Rows.Count; xlRowCnt++)

            {

                Username = (string)(x1Range.Cells[xlRowCnt, 1] as excel.Range).Value2;

                Password = (string)(x1Range.Cells[xlRowCnt, 2] as excel.Range).Value2;

             //   Role = (string)(x1Range.Cells[xlRowCnt, 3] as excel.Range).Value2;



                //Initializes webdriver

                IWebDriver driver = new ChromeDriver();

                driver.Url = "http://newtours.demoaut.com/index.php?osCsid=ba3433dc70040ac22c60c621efe1bfff";


                driver.FindElement(By.Name("userName")).SendKeys(Username);
                driver.FindElement(By.Id("password")).SendKeys(Password);
                driver.FindElement(By.Name("login")).Click() ;





            }

            x1WorkBook.Close();

            x1Appl.Quit();



        }

    }

}
