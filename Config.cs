using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TylerGray_Ensurem {
    public static class Config {
        public static readonly int ElementsWaitingTimeout = 10;
        public static readonly string TestURL = "https://ensurem.com/quote/medicare-supplement/";
    }
}
