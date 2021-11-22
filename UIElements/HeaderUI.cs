using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TylerGray_Ensurem {
    public class HeaderUI {
        public HeaderUI(IWebDriver driver) {
            PageFactory.InitElements(driver, this);
        }

        //Ensurem Logo
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.l-navbar-fixed-top:nth-child(3) nav.l-navbar a:nth-child(1) > div.brand-dark.brand-left.opacity-hover-80.l-float-l")]
        public IWebElement EnsuremLogo { get; set; }

        //Products Dropdown
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.l-navbar-fixed-top:nth-child(3) nav.l-navbar ul.menu:nth-child(4) li.menu-item.menu-item-type-custom.menu-item-object-custom.menu-item-has-children.main-wrapper.menu-item-12544:nth-child(1) > a:nth-child(1)")]
        public IWebElement Products { get; set; }

        //Learn Dropdown
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.l-navbar-fixed-top:nth-child(3) nav.l-navbar ul.menu:nth-child(4) li.menu-item.menu-item-type-post_type.menu-item-object-page.menu-item-14867:nth-child(2) > a:nth-child(1)")]
        public IWebElement Learn { get; set; }

        //About Dropdown
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.l-navbar-fixed-top:nth-child(3) nav.l-navbar ul.menu:nth-child(4) li.menu-item.menu-item-type-custom.menu-item-object-custom.menu-item-12546:nth-child(3) > a:nth-child(1))")]
        public IWebElement About { get; set; }

        //News Dropdown
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.l-navbar-fixed-top:nth-child(3) nav.l-navbar ul.menu:nth-child(4) li.menu-item.menu-item-type-custom.menu-item-object-custom.menu-item-has-children.main-wrapper.menu-item-12544:nth-child(4) > a:nth-child(1)")]
        public IWebElement News { get; set; }

        //Search
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.l-navbar-fixed-top:nth-child(3) nav.l-navbar ul.menu:nth-child(4) li.foot-hide.menu-item.menu-item-type-custom.menu-item-object-custom.menu-item-14680:nth-child(5) > a:nth-child(1)")]
        public IWebElement Search { get; set; }
    }
}
