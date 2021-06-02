

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;

namespace ExecutarTest
{
    public class  Session
    {
  
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string AppId = "C:\\Users\\rafae\\source\\repos\\Automacao\\Automacao\\bin\\Debug\\Automacao.exe";

       
        private const string WinAppiumExe = "C:\\Users\\rafae\\source\\repos\\Automacao\\tools\\Windows Application Driver\\WinAppDriver.exe";

        protected static WindowsDriver<WindowsElement> session;

        public static void Setup(TestContext context)
        {
            if (session == null)
            {

                Process.Start(WinAppiumExe);
                DesiredCapabilities appCapabilities = new DesiredCapabilities();
                appCapabilities.SetCapability("app", AppId);
                appCapabilities.SetCapability("deviceName", "WindowsPC");
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
              
                session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
            }
        }

        public static void TearDown()
        {

            if (session != null)
            { 
                session.Quit();
                session = null;
            }
        }
    }
}
