using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using EAEmployeeTest.Pages;
using EAAutoFramework.Base;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System;
using EAAutoFramework.Helpers;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
        string url = "http://localhost/";

        public void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.IE:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExelHelpers.PopulateInCollection(fileName);

            OpenBrowser(BrowserType.Chrome);
            DriverContext.Browser.GoToUrl(url);

            //Login page
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login(ExelHelpers.ReadData(1,"UserName"), ExelHelpers.ReadData(1,"Password"));

            //Employee page
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();
            CurrentPage.As<EmployeePage>().ClickCreateNew();
        }
    }
}
