using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public static class Env
    {
        public static string rootDirectory = System.IO.Path.GetFullPath($"{AppDomain.CurrentDomain.BaseDirectory.ToString()}/../../../..");

        static public bool IsSauce()
        {
            return Environment.GetEnvironmentVariable("SAUCE_LABS") != null;
        }

        static public Uri ServerUri()
        {
            string sauceUserName = Environment.GetEnvironmentVariable("SAUCE_USERNAME");
            string sauceAccessKey = Environment.GetEnvironmentVariable("SAUCE_ACCESS_KEY");

            return sauceUserName == null || sauceAccessKey == null
                ? new Uri("http://localhost:4723/wd/hub")
                : new Uri($"https://{sauceUserName}:{sauceAccessKey}@ondemand.saucelabs.com:80/wd/hub");
        }

        public static TimeSpan INIT_TIMEOUT_SEC = TimeSpan.FromSeconds(180);
        public static TimeSpan IMPLICIT_TIMEOUT_SEC = TimeSpan.FromSeconds(10);
    }

    public static class App
    {
        static public string AndroidApp()
        {
            //return Env.IsSauce() ? "http://appium.github.io/appium/assets/ApiDemos-debug.apk" : $"{Env.rootDirectory}/apps/ApiDemos-debug.apk";
            return "C:\\Users\\henri\\Downloads\\app-beta-debug.apk";
        }

        static public string AndroidDeviceName()
        {
            return Environment.GetEnvironmentVariable("ANDROID_DEVICE_VERSION") ?? "Android";
        }

        static public string AndroidPlatformVersion()
        {
            return Environment.GetEnvironmentVariable("ANDROID_PLATFORM_VERSION") ?? "11.0";
        }
    }
}
