using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
        //Objects for the Login page
        [FindsBy(How = How.LinkText, Using = "Log in")]
        IWebElement lnkLogin { get; set; }

        [FindsBy(How = How.LinkText, Using = "Employee List")]
        IWebElement lnkEmployeeList { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        IWebElement btnLogin { get; set; }

        /// <summary>
        /// Logins the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }

        /// <summary>
        /// Clicks the login link.
        /// </summary>
        public void ClickLoginLink()
        {
            lnkLogin.Click();
        }

        /// <summary>
        /// Clicks the employee list.
        /// </summary>
        /// <returns>EmployeePage</returns>
        public EmployeePage ClickEmployeeList()
        {
            lnkEmployeeList.Click();
            return GetInstance<EmployeePage>();
        }
    }
}
