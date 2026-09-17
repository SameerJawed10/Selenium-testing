using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DataDriven
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        // 1. Valid Login Scenario 1
        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Data.xml",
            "ValidLogin1",
            DataAccessMethod.Sequential)]
        public void Test_ValidLogin1()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                string url = TestContext.DataRow["url"].ToString();
                string username = TestContext.DataRow["username"].ToString();
                string password = TestContext.DataRow["password"].ToString();
                string expectedText = TestContext.DataRow["expectedText"].ToString();

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(url);

                driver.FindElement(By.Id("user-name")).SendKeys(username);
                driver.FindElement(By.Id("password")).SendKeys(password);
                driver.FindElement(By.Id("login-button")).Click();

                string actualText =
                    driver.FindElement(By.ClassName("title")).Text;

                Assert.AreEqual(expectedText, actualText);
            }
            finally
            {
                driver.Quit();
            }
        }


        // 2. Valid Login Scenario 2
        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Data.xml",
            "ValidLogin2",
            DataAccessMethod.Sequential)]
        public void Test_ValidLogin2()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                string url = TestContext.DataRow["url"].ToString();
                string username = TestContext.DataRow["username"].ToString();
                string password = TestContext.DataRow["password"].ToString();
                string expectedText = TestContext.DataRow["expectedText"].ToString();

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(url);

                driver.FindElement(By.Id("user-name")).SendKeys(username);
                driver.FindElement(By.Id("password")).SendKeys(password);
                driver.FindElement(By.Id("login-button")).Click();

                string actualText =
                    driver.FindElement(By.ClassName("title")).Text;

                Assert.AreEqual(expectedText, actualText);
            }
            finally
            {
                driver.Quit();
            }
        }


        // 3. Invalid Login Scenario
        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Data.xml",
            "InvalidLogin",
            DataAccessMethod.Sequential)]
        public void Test_InvalidLogin()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                string url = TestContext.DataRow["url"].ToString();
                string username = TestContext.DataRow["username"].ToString();
                string password = TestContext.DataRow["password"].ToString();
                string expectedText = TestContext.DataRow["expectedText"].ToString();

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(url);

                driver.FindElement(By.Id("user-name")).SendKeys(username);
                driver.FindElement(By.Id("password")).SendKeys(password);
                driver.FindElement(By.Id("login-button")).Click();

                string actualText =
                    driver.FindElement(By.CssSelector("[data-test='error']")).Text;

                Assert.AreEqual(expectedText, actualText);
            }
            finally
            {
                driver.Quit();
            }
        }


        // 4. Empty Login Scenario
        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Data.xml",
            "EmptyLogin",
            DataAccessMethod.Sequential)]
        public void Test_EmptyLogin()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                string url = TestContext.DataRow["url"].ToString();
                string username = TestContext.DataRow["username"].ToString();
                string password = TestContext.DataRow["password"].ToString();
                string expectedText = TestContext.DataRow["expectedText"].ToString();

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(url);

                driver.FindElement(By.Id("user-name")).SendKeys(username);
                driver.FindElement(By.Id("password")).SendKeys(password);
                driver.FindElement(By.Id("login-button")).Click();

                string actualText =
                    driver.FindElement(By.CssSelector("[data-test='error']")).Text;

                Assert.AreEqual(expectedText, actualText);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}