using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace PlayWriteClassLibrary
{
    public class WebDriverWrapper
    {
        private IWebDriver driver;
       
        public void Initialisation(string browserName)
        {
            if(browserName.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if(browserName.Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                throw new ArgumentException("Please enter proper browsername");
            }
                
            driver.Manage().Window.Maximize();
        }

        public void NavigateUrl(string url)
        {
            driver.Url = url;
        }

        public string GetCode()
        {
            string codeText= driver.FindElement(By.XPath("//div[@class='markdown']//div[1]//div[1]//pre[1]//code[1]")).Text;
            return codeText;
        }

        public void TearDown()
        {
            driver.Quit();
        }

    }
}
