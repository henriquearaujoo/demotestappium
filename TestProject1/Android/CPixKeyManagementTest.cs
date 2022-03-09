using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Android
{
    public class CPixKeyManagementTest
    {
        private AndroidDriver<AndroidElement> driver;

        [SetUp]
        public void Setup()
        {
            driver = DriverManager.Instance().Driver;
        }

        [Test]
        public void ShouldRegisterCPFPixKey()
        {
            driver.FindElementById("button_key_management").Click();

            driver.FindElementById("button_new_key").Click();

            driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]/android.widget.LinearLayout").Click();

            driver.FindElementById("button_confirm").Click();

            driver.FindElementById("button").Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Assert.AreEqual("Chave para o endereçamento cadastrada com sucesso!", driver.FindElementById("label_status").Text);

        }

        [Ignore("ignore")]
        public void ShouldRegisterEmailPixKey()
        {
            driver.FindElementById("button_key_management").Click();

            driver.FindElementById("button_new_key").Click();

            driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[3]/android.widget.LinearLayout").Click();

            driver.FindElementById("button_confirm").Click();

            driver.FindElementById("edt_email").SendKeys("t0033332@ailos.coop.br");

            driver.HideKeyboard();

            driver.FindElementById("button").Click();
        }
    }
}
