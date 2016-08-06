using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
        //Objects for the Login page
        [FindsBy(How = How.LinkText, Using = "Log in")]
        public IWebElement lnkLogin { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement btnLogin { get; set; }
    }
}
