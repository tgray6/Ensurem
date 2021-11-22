using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TylerGray_Ensurem {
    public class QuoteFormUI {
        public QuoteFormUI(IWebDriver driver) {
            PageFactory.InitElements(driver, this);
        }

        //Zip Code Field
        [FindsBy(How = How.CssSelector, Using = "#zip-2")]
        public IWebElement ZipCode { get; set; }

        //Birthdate Field
        [FindsBy(How = How.CssSelector, Using = "#birthdate-3")]
        public IWebElement Birthdate { get; set; }

        //Gender Dropdown
        [FindsBy(How = How.CssSelector, Using = "#gender-0")]
        public IWebElement GenderDropdown { get; set; }

        //Tobacco Use Dropdown
        [FindsBy(How = How.CssSelector, Using = "#tobaccoUser-1")]
        public IWebElement TobaccoDropdown { get; set; }

        //News Dropdown
        [FindsBy(How = How.CssSelector, Using = "#firstname-4")]
        public IWebElement FirstName { get; set; }

        //Last Name Field
        [FindsBy(How = How.CssSelector, Using = "#lastname-5")]
        public IWebElement LastName { get; set; }

        //Phone Number Field
        [FindsBy(How = How.CssSelector, Using = "#phone-6")]
        public IWebElement PhoneNumber { get; set; }

        //Email Field
        [FindsBy(How = How.CssSelector, Using = "#email-7")]
        public IWebElement Email { get; set; }

        //Get Quote Button
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/main[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form[1]/div[5]/div[1]/div[1]/button[1]")]
        public IWebElement GetQuoteButton { get; set; }

        //Read More Button
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.overflow-hidden.position-relative.pb-5.bg-white section.py-5.mb-5 div.hero__inner div.hero__row div.col-md-8.offset-md-2 div.card.border-0.shadow-lg.mt-5 div.card__body form.form.mt-2.start-anime.was-validated div.form__disclaimer:nth-child(6) div.truncate div.truncate-text:nth-child(1) p:nth-child(1) span.moreellipses > a.btn.btn-link.btn-sm.mt-3.moreless.more:nth-child(2)")]
        public IWebElement ReadMoreButton { get; set; }


        /*
        ERROR MESSAGES
        */

        //Invalid Zip Code Error Message
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.overflow-hidden.position-relative.pb-5.bg-white section.py-5.mb-5 div.hero__inner div.hero__row div.col-md-8.offset-md-2 div.card.border-0.shadow-lg.mt-5 div.card__body form.form.mt-2.start-anime.was-validated div.form-row:nth-child(1) div.col-sm:nth-child(1) div.form__group.zip > div.invalid-feedback:nth-child(4)")]
        public IWebElement InvalidZipCodeMessage { get; set; }

        //Invalid Birth Date Error Message
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.overflow-hidden.position-relative.pb-5.bg-white section.py-5.mb-5 div.hero__inner div.hero__row div.col-md-8.offset-md-2 div.card.border-0.shadow-lg.mt-5 div.card__body form.form.mt-2.start-anime.was-validated div.form-row:nth-child(1) div.col-sm:nth-child(2) div.form__group.birthdate > div.invalid-feedback:nth-child(4)")]
        public IWebElement InvalidBirthDateMessage { get; set; }

        //Valid Birth Date Error Message
        [FindsBy(How = How.CssSelector, Using = "body.theme-ensurem:nth-child(2) div.overflow-hidden.position-relative.pb-5.bg-white section.py-5.mb-5 div.hero__inner div.hero__row div.col-md-8.offset-md-2 div.card.border-0.shadow-lg.mt-5 div.card__body form.form.mt-2.start-anime.was-validated div.form-row:nth-child(1) div.col-sm:nth-child(2) div.form__group.birthdate > div.valid-feedback:nth-child(3)")]
        public IWebElement ValidBirthDateMessage { get; set; }

    }
}
