using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class FunctionalTests
    {
        [Test]
        public void Title01()
        {
            var options = new ChromeOptions();
            options.AddArgument("--allow-insecure-localhost");
            using var browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl("https://localhost:5001/");
            Assert.AreEqual("Home Page - To-Do Lists", browser.Title);
        }
        
        [Test]
        public void HomePageNavbarLink02()
        {
            var options = new ChromeOptions();
            options.AddArgument("--allow-insecure-localhost");
            using var browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl("https://localhost:5001/");
            var homePageLinkElement = browser.FindElement(By.Id("homePageNavbarLink"));
            StringAssert.Contains("To-Do", homePageLinkElement.Text);
        }
    }
}