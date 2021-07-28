using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetseleniumdemo.Tools;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace dotnetseleniumdemo
{    public class ChangeColorTest
    {
        public IWebDriver driver;
        private readonly string site;

        
        public ChangeColorTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            site = "https://mango-flower-00e2aa010.azurestaticapps.net/";
        }

        [Fact]
        public void ChangeToBlueColor()
        {
            driver.Navigate().GoToUrl(site);
            System.Threading.Thread.Sleep(1000);
            var blueBox =  driver.FindElement(By.ClassName("color-blue"));
            blueBox.Click();
            System.Threading.Thread.Sleep(1000);
            var container =  driver.FindElement(By.ClassName("color-container"));            

            Assert.Equal("color-container color-blue", container.GetAttribute("class"));
            driver.Close();
        }

        [Fact]
        public void ChangeToGreenColor()
        {
            driver.Navigate().GoToUrl(site);
            System.Threading.Thread.Sleep(1000);
            var blueBox =  driver.FindElement(By.ClassName("color-green"));
            blueBox.Click();
            System.Threading.Thread.Sleep(1000);
            var container =  driver.FindElement(By.ClassName("color-container"));
           
            Assert.Equal("color-container color-green", container.GetAttribute("class"));
            driver.Close();

        }
      
    }
}