using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace AppiumTest
{
    [TestClass]
    public class BaseTest
    {
        private const string CapabilityValue = "donatelo";
        private const string Capability = "deviceName";

        //Crearting Instance for Appium 
        AppiumDriver<IWebElement> driver;

        private void Init()
        {
            AppiumOptions dc = new AppiumOptions();
            dc.AddAdditionalCapability("", "");
            driver = new AndroidDriver<IWebElement>(new Uri("", dc));

        }

        [TestMethod]
        public void AppiumFirstTest()
        {

        }
    }
}
