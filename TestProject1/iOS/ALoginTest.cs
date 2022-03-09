using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using TestProject1.Android;

namespace TestProject1.iOS
{
    public class ALoginTest
    {
        private IOSDriver<IOSElement> driver;

        [SetUp]
        public void Setup()
        {
            driver = DriverManager.Instance().Driver;
        }

        [Test]
        public void ShouldTestLoginApp()
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