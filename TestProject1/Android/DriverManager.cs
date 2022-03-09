using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Android;

namespace TestProject1
{
    public class DriverManager
    {
        private AndroidDriver<AndroidElement> driver;
        static DriverManager instance;

        public AndroidDriver<AndroidElement> Driver { get => driver; private set => driver = value; }

        protected DriverManager()
        {
            AppiumOptions caps = new AppiumOptions();
            caps.AddAdditionalCapability(MobileCapabilityType.BrowserName, "");
            caps.AddAdditionalCapability(MobileCapabilityType.PlatformName, App.AndroidDeviceName());
            caps.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, App.AndroidPlatformVersion());
            caps.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UIAutomator2");
            caps.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 2 API 30");
            caps.AddAdditionalCapability("autoGrantPermissions", "true");
            //caps.AddAdditionalCapability("appActivity", ".app.SearchInvoke");
            caps.AddAdditionalCapability("appActivity", "br.coop.cecred.cecredmobile.splash.SplashActivity");
            caps.AddAdditionalCapability(MobileCapabilityType.App, App.AndroidApp());

            driver = new AndroidDriver<AndroidElement>(Env.ServerUri(), caps, Env.INIT_TIMEOUT_SEC);
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
