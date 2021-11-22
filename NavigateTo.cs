using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TylerGray_Ensurem {
    class NavigateTo {

        //In actual job, this class is used to navigate to different features in simple english by typing "NavigateTo.(Insert Where to go). Below is an example of how we would go to different parts in the header by passing in the driver in the actual test

        //Clicks news in header by calling: NavigateTo.News
        public static void News(IWebDriver driver) {
            HeaderUI header = new HeaderUI(driver);
            header.News.Click();
        }
    }
}
