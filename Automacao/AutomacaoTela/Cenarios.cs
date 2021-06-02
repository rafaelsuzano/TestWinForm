
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using System.Threading;
using System;
using ExecutarTest;

namespace ExecutarTests
{
    [TestClass]
    public class ScenarioStandard : Session
    {
     

        [TestMethod]
        public void PreencheCampo()
        {
            
            session.FindElementByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1").SendKeys("rafael");

        }

        [TestMethod]
        public void TesteRadioButton()
        {
         
            session.FindElementByClassName("WindowsForms10.BUTTON.app.0.141b42a_r7_ad1").Click();
            session.FindElementByClassName("Button").Click();
        }


        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            
            Setup(context);

      
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        [TestInitialize]
        public void Clear()
        {
         
        }

      
    }
}
