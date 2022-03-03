using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace TestProject1
{
    public class Tests
    {
        private AndroidDriver<AndroidElement> driver;

        [SetUp]
        public void Setup()
        {
            AppiumOptions caps = new AppiumOptions();
            caps.AddAdditionalCapability(MobileCapabilityType.BrowserName, "");
            caps.AddAdditionalCapability(MobileCapabilityType.PlatformName, App.AndroidDeviceName());
            caps.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, App.AndroidPlatformVersion());
            caps.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UIAutomator2");
            caps.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 2 API 30");
            //caps.AddAdditionalCapability("appActivity", ".app.SearchInvoke");
            caps.AddAdditionalCapability("appActivity", "br.coop.cecred.cecredmobile.splash.SplashActivity");
            caps.AddAdditionalCapability(MobileCapabilityType.App, App.AndroidApp());

            driver = new AndroidDriver<AndroidElement>(Env.ServerUri(), caps, Env.INIT_TIMEOUT_SEC);
            driver.Manage().Timeouts().ImplicitWait = Env.IMPLICIT_TIMEOUT_SEC;
        }

        [Test]
        public void Test1()
        {
            driver.FindElementById("btn_access_account").Click();

            driver.FindElementById("spinner_cooperative").Click();

            driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.TextView[12]").Click();

            //Numero da conta
            driver.FindElementById("edt_account_number").SendKeys("6700");

            driver.FindElementById("spinner_holder").Click();

            //Senha
            driver.FindElementById("edt_password").SendKeys("00000000");

            //Frase de segurança
            driver.FindElementById("edt_phrase").SendKeys("0000000000");

            driver.HideKeyboard();

            driver.FindElementById("btn_login").Click();

            driver.FindElementById("btn_negative").Click();

            driver.FindElementById("btn_positive").Click();

            //inserir cpf para autorizar dispositivo
            driver.FindElementById("textinput_placeholder").Click();
            new Actions(driver).SendKeys("09071620964").Perform();

            driver.FindElementById("edt_password").SendKeys("00000000");

            driver.FindElementById("edt_token").SendKeys("abc");

            driver.FindElementById("btn_confirm").Click();
        }
    }
}