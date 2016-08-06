using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class EmployeePage : BasePage
    {
        [FindsBy(How = How.Name, Using = "searchTerm")]
        public IWebElement lnkLogin { get; set; }
    }
}
