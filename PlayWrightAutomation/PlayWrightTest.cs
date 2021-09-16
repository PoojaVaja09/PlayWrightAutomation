using NUnit.Framework;
using PlayWriteClassLibrary;
using System;

namespace PlayWrightAutomation
{
    public class PlayWrightTest
    {
        
        [Test]
        public void PlayWrightDemoAndBrowserCode()
        {
            WebDriverWrapper webDriverWrapper = new WebDriverWrapper();
            webDriverWrapper.Initialisation("chrome");
            webDriverWrapper.NavigateUrl("https://playwright.dev/dotnet/docs/why-playwright/");
            webDriverWrapper.NavigateUrl("https://playwright.dev/dotnet/docs/core-concepts");

            string code = webDriverWrapper.GetCode();
            Console.WriteLine(code);

            webDriverWrapper.TearDown();
        }
    }
}