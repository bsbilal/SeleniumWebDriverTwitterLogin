using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumBegin
{
    [TestFixture]

    public class Tests
    {
        IWebDriver explorer = new FirefoxDriver();

        [Test]
        public void LoginTest()
        {
            string kullaniciadi = "username";
            string sifre = "password";
            explorer.Navigate().GoToUrl("https://twitter.com/");// send link to browser 

            explorer.FindElement(By.Name("session[username_or_email]")).Clear();
            explorer.FindElement(By.Name("session[username_or_email]")).SendKeys($"{kullaniciadi}");//login

            explorer.FindElement(By.Name("session[password]")).Clear();
            explorer.FindElement(By.Name("session[password]")).SendKeys($"{sifre}");//pass

            explorer.FindElement(By.CssSelector("div[data-testid=LoginForm_Login_Button]")).Click();// click button

            Assert.Pass("Login succesful");
        
        }
    }
}