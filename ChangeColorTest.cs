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
        private readonly IConfiguration config;

        
        public ChangeColorTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            config = ConfigutationManager.InitConfiguration();
        }

        [Fact]
        public void ChangeToBlueColor()
        {
            driver.Navigate().GoToUrl(config["site"]);
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
            driver.Navigate().GoToUrl(config["site"]);
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