using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Android
{
    public class BPixMenuTest
    {
        private AndroidDriver<AndroidElement> driver;

        [SetUp]
        public void Setup()
        {
            driver = DriverManager.Instance().Driver;
        }

        [Test]
        public void ShouldTestPixMenu()
        {
            driver.FindElementById("menu_pix").Click();

            driver.FindElementById("button_confirm").Click();
        }
    }
}
