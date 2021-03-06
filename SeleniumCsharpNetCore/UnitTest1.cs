using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCsharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;

        /*
         * DB Connection String
         * workstation id=EAEmployeeDB.mssql.somee.com;packet size=4096;user id=kartmcad_SQLLogin_1;pwd=wtzaxoan1l;data source=EAEmployeeDB.mssql.somee.com;persist security info=False;initial catalog=EAEmployeeDB
         * public url http://eaapp.somee.com/
         * 
        */

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Console.WriteLine("Setup");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.FindElement(By.Id("btnCookie")).Click();
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            var ComboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            ComboControl.Clear();
            ComboControl.SendKeys("Almonds");
            Console.WriteLine("Test1");
            Assert.Pass();
        }

        [TearDown]
        public void CloseDriver()
        {
            Driver.Close();
            Console.WriteLine("TearDown");
        }
    }
}