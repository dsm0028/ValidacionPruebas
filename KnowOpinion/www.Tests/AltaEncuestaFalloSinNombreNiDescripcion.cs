using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTests
{
    [TestClass]
    public class AltaEncuestaFalloSinNombreNiDescripcion
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [TestInitialize]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:2193";
            verificationErrors = new StringBuilder();
        }
        
        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [TestMethod]
        public void TheAltaEncuestaFalloSinNombreNiDescripcionTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Login.aspx");
            driver.FindElement(By.Id("Tbox_usuario")).Clear();
            driver.FindElement(By.Id("Tbox_usuario")).SendKeys("comandante666");
            driver.FindElement(By.Id("Tbx_contraseņa")).Clear();
            driver.FindElement(By.Id("Tbx_contraseņa")).SendKeys("jofrillos");
            driver.FindElement(By.Id("Btn_Login")).Click();

            driver.Navigate().GoToUrl(baseURL + "/Menu.aspx");
            driver.FindElement(By.Id("Button_AltaEncuesta")).Click();
            driver.FindElement(By.Id("Button_Aceptar")).Click();
            // Warning: assertTextPresent may require manual changes
            Assert.IsTrue(Regex.IsMatch(driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*$"));
            // Warning: assertTextPresent may require manual changes
            Assert.IsTrue(Regex.IsMatch(driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*$"));
            // Warning: assertTextPresent may require manual changes
            Assert.IsTrue(Regex.IsMatch(driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*$"));
            Assert.AreEqual("Error! Introduzca nombre y descripcion", driver.FindElement(By.Id("Lbl_AltaFallido")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
