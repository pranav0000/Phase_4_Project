using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace Nunit_selinium_test_Phase_4
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"D:\");
            Thread.Sleep(1000);
        }



        [Test]
        // This test case should Pass
        // because there is one header element with id "pizza_list"
        // And the credentials provided are correct
        public void Test1()
        {
            driver.Url = "https://localhost:44309/";

            // Entering Username and password
            driver.FindElement(By.Id("CustomerUname")).SendKeys("Pranav@12");
            driver.FindElement(By.Id("CustomerPwd")).SendKeys("1234");

            // Hitting Send Button 
            driver.FindElement(By.Id("btn_login")).Click();

            // Checking if the user is getting navigating to Pizza List page or not 

            driver.FindElement(By.Id("pizza_list"));

            
        }



        [Test]
        // This test case should fail
        // becuase there is no such element with id "pizza_li"
        // Credentials provided are correct
        public void Test2()
        {
            driver.Url = "https://localhost:44309/";

            // Entering Username and password
            driver.FindElement(By.Id("CustomerUname")).SendKeys("Pranav@12");
            driver.FindElement(By.Id("CustomerPwd")).SendKeys("1234");

            // Hitting Send Button 
            driver.FindElement(By.Id("btn_login")).Click();

            // Checking if the user is getting navigating to Pizza List page or not 

            driver.FindElement(By.Id("pizza_li"));
        }


        [Test]
        // This test case should pass
        // The credentials are incorrect and that element should pop up"
        public void Test3()
        {
            driver.Url = "https://localhost:44309/";

            // Entering Username and password
            driver.FindElement(By.Id("CustomerUname")).SendKeys("Arvind@12"); 
            driver.FindElement(By.Id("CustomerPwd")).SendKeys("Wrong@Creds"); // wrong cred

            // Hitting Send Button 
            driver.FindElement(By.Id("btn_login")).Click();

            // Checking if "incorrect_creds" pops up or not 

            driver.FindElement(By.Id("incorrect_creds"));
        }


    }
}