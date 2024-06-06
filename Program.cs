using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Starting Login...");

// Open Chrome browser
IWebDriver driver = new EdgeDriver();
driver.Navigate().GoToUrl("url");

// Wait for page to load
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

// Get cookies
// Wait for user to sign in
Thread.Sleep(TimeSpan.FromSeconds(30)); // Adjust the delay as needed

var cookies = driver.Manage().Cookies.AllCookies;
foreach (var cookie in cookies)
{
    Console.WriteLine(cookie.Name + ": " + cookie.Value);
}

// Close the browser
driver.Quit();
