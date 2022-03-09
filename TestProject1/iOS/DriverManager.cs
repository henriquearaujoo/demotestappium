using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.iOS
{
    public class DriverManager
    {
        private IOSDriver<IOSElement> driver;
        static DriverManager instance;

        public IOSDriver<IOSElement> Driver { get => driver; private set => driver = value; }

        protected DriverManager()
        {
            AppiumOptions caps = new AppiumOptions();
            caps.AddAdditionalCapability(MobileCapabilityType.BrowserName, "");
            caps.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            caps.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "14.4");
            caps.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
            caps.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 12 Pro Max");
            caps.AddAdditionalCapability("autoGrantPermissions", "true");
            caps.AddAdditionalCapability(MobileCapabilityType.App, "");

            driver = new IOSDriver<IOSElement>(Env.ServerUri(), caps, Env.INIT_TIMEOUT_SEC);
            driver.Manage().Timeouts().ImplicitWait = Env.IMPLICIT_TIMEOUT_SEC;
        }

        public static DriverManager Instance()
        {
            if (instance is null)
                instance = new DriverManager();

            return instance;
        }
    }
}
