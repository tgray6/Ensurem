using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TylerGray_Ensurem.Scenarios {

    [Parallelizable]
    class MedicareRequestQuote {
        private IWebDriver Driver { get; set; }

        //CSS Selectors
        private string _invalidZipCodeCSSPath = "body.theme-ensurem:nth-child(2) div.overflow-hidden.position-relative.pb-5.bg-white section.py-5.mb-5 div.hero__inner div.hero__row div.col-md-8.offset-md-2 div.card.border-0.shadow-lg.mt-5 div.card__body form.form.mt-2.start-anime.was-validated div.form-row:nth-child(1) div.col-sm:nth-child(1) div.form__group.zip > div.invalid-feedback:nth-child(4)";

        private string _validBirthDateCSSPath = "body.theme-ensurem:nth-child(2) div.overflow-hidden.position-relative.pb-5.bg-white section.py-5.mb-5 div.hero__inner div.hero__row div.col-md-8.offset-md-2 div.card.border-0.shadow-lg.mt-5 div.card__body form.form.mt-2.start-anime.was-validated div.form-row:nth-child(1) div.col-sm:nth-child(2) div.form__group.birthdate > div.valid-feedback:nth-child(3)";


        //Response messages from Site, used for Assert.AreEqual
        private string _invalidZipCodeErrorMessage = "Please enter a valid ZIP code like 12345. This field is required.";
        private string _invalidBirthDateErrorMessage = "Something's wrong here. This field is required."; 

        [OneTimeSetUp]
        public void Initialize() {
            Driver = Action.InitializeDriver();
        }

        //MedicareQuote_01
        [Test]
        public void AllFieldsEmpty() {

        }

        //MedicareQuote_02
        [Test]
        public void InvalidZipCode() {
            QuoteFormUI quoteform = new QuoteFormUI(Driver);
            quoteform.ZipCode.SendKeys("1234");
            quoteform.GetQuoteButton.Click();
            Action.WaitForCssElement(_invalidZipCodeCSSPath, Driver);
            Assert.AreEqual(_invalidZipCodeErrorMessage, quoteform.InvalidZipCodeMessage.Text);
        }

        //MedicareQuote_03
        [Test]
        public void ZipCodeOverflow() {

        }

        //MedicareQuote_04
        [Test]
        public void BirthdateBefore1900() {

        }

        //MedicareQuote_05
        [Test]
        public void BirthdateNonExistentMonthAndDay() {

        }

        //MedicareQuote_06
        [Test]
        public void BirthdateFuture() {
            QuoteFormUI quoteform = new QuoteFormUI(Driver);
            quoteform.ZipCode.SendKeys("12345");
            quoteform.Birthdate.SendKeys("10/30/2022");
            quoteform.GetQuoteButton.Click();
            Assert.AreEqual(_invalidBirthDateErrorMessage, quoteform.InvalidBirthDateMessage.Text);
        }




        [OneTimeTearDown]
        public void TearDown() {
            Driver.Quit();
        }
    }
}
