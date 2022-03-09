using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Android;

namespace TestProject1
{
    public class DriverIOS
    {
        private IOSDriver<IOSElement> driver;
        static DriverIOS instance;

        public IOSDriver<IOSElement> Driver { get => driver; private set => driver = value; }

        protected DriverIOS()
        {
            AppiumOptions caps = new AppiumOptions();
            caps.AddAdditionalCapability(MobileCapabilityType.BrowserName, "");
            caps.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            caps.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, App.IOSPlatformVersion());
            caps.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
            caps.AddAdditionalCapability(MobileCapabilityType.DeviceName, App.IOSDeviceName());
            caps.AddAdditionalCapability(MobileCapabilityType.App, App.IOSApp());
            caps.AddAdditionalCapability("autoGrantPermissions", "true");

            driver = new IOSDriver<IOSElement>(Env.ServerUri(), caps, Env.INIT_TIMEOUT_SEC);
            driver.Manage().Timeouts().ImplicitWait = Env.IMPLICIT_TIMEOUT_SEC;
        }

        public static DriverIOS Instance()
        {
            if (instance is null) 
                instance = new DriverIOS();

            return instance;
        }
    }
}
