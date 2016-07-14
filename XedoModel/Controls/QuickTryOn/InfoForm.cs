using System;
using System.Diagnostics;
using System.Threading;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XedoModel.Controls.QuickTryOn
{
    public class InfoForm : ControlBase
    {
        public InfoForm(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public SelectElement HeightSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.HeightSelect)); }
        }

        public SelectElement WeightSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.WeightSelect)); }
        }

        public SelectElement CoatSizeSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.CoatSizeSelect)); }
        }

        public InputBox FirstNameInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.FirstNameInputBox)); }
        }

        public InputBox LastNameInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.LastNameInputBox)); }
        }

        public InputBox AddressOneInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.AddressOneInputBox)); }
        }

        public InputBox AddressTwoInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.AddressTwoInputBox)); }
        }

        public InputBox CityInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.CityInputBox)); }
        }

        public SelectElement StateSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.StateSelect)); }
        }

        public InputBox ZipInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.ZipInputBox)); }
        }

        public IWebElement ConfirmDeliveryAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmDeliveryAddressButton); }
        }

        public IWebElement SaveAsDefaultAddressCheckbox
        {
            get { return Driver.FindElement(Container, Locators.SaveAsDefaultAddressCheckbox); }
        }

        public InputBox ContactNumberInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.ContactNumberInputBox)); }
        }

        public IWebElement WeddingDateSelector
        {
            get { return Driver.FindElement(Container, Locators.WeddingDateSelector); }
        }

        public IWebElement PreferredTryOnDateSelector
        {
            get { return Driver.FindElement(Container, Locators.PreferredTryOnDateSelector); }
        }

        public IWebElement CollectionDateLabel
        {
            get { return Driver.FindElement(Container, Locators.CollectionDateLabel); }
        }

        public IWebElement SuggestedAddressLabel
        {
            get { return Driver.FindElement(Container, Locators.SuggestedAddressLabel); }
        }

        public IWebElement ConfirmUserEnteredAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmUserEnteredAddressButton); }
        }

        public IWebElement ConfirmSuggestedAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmSuggestedAddressButton); }
        }

        public IWebElement InvalidZipErrorLabel
        {
            get { return Driver.FindElement(Container, Locators.InvalidZipErrorLabel); }
        }

        public DatePicker WeddingDateDatePicker
        {
            get
            {
                WeddingDateSelector.Click();
                Thread.Sleep(250);
                return new DatePicker(TestSettings, Driver.FindElement(Locators.WeddingDateDatePickerContainer));
            }
        }

        public DatePicker PreferredDateDatePicker
        {
            get
            {
                PreferredTryOnDateSelector.Click();
                Thread.Sleep(250);
                return new DatePicker(TestSettings, Driver.FindElement(Locators.PreferredDateDatePickerContainer));
            }
        }
        
        public void SetToManualAddressInput()
        {
            if (Driver.ElementDisplayed(Container, Locators.InputNewAddressButton))
            {
                Driver.FindElement(Container, Locators.InputNewAddressButton).Click();
            }
        }

        public string CollectionDate
        {
            get
            {
                var date = "";
                var s = new Stopwatch();
                s.Start();
                while (date == "" && s.Elapsed < TimeSpan.FromSeconds(10))
                {
                    date = CollectionDateLabel.Text;
                }
                s.Stop();
                return date;
            }
        }

        public void SelectHeight(int feet, int inches)
        {
            HeightSelect.SelectByValue(string.Format("{0}'{1}\"", feet, inches));
        }

        public void SelectWeight(int pounds)
        {
            WeightSelect.SelectByValue(pounds.ToString());
        }

        public void SelectCoatSize(int inches, string size)
        {
            CoatSizeSelect.SelectByText(string.Format("{0}\" {1}", inches, size.ToUpper()));
        }

        public void SelectStateByName(string name)
        {
            StateSelect.SelectByText(name);
        }

        public void SelectStateByPostalCode(string postalCode)
        {
            CoatSizeSelect.SelectByValue(postalCode);
        }

        public void ConfirmDeliveryAddress()
        {
            ConfirmDeliveryAddressButton.Click();
            Driver.WaitForElementToDisappear(Locators.ConfirmDeliveryAddressButtonSpinner);
        }

        public void SaveAsDefaultAddress()
        {
            if (!SaveAsDefaultAddressCheckbox.Selected)
            {
                SaveAsDefaultAddressCheckbox.Click();
            }
        }

        public void DoNotSaveAsDefaultAddress()
        {
            if (SaveAsDefaultAddressCheckbox.Selected)
            {
                SaveAsDefaultAddressCheckbox.Click();
            }
        }

        public bool AddressConfirmed
        {
            get { return ConfirmedAddress != ""; }
        }

        public string ConfirmedAddress
        {
            get { return Driver.FindElement(Container, Locators.ConfirmedAddressLabel).Text; }
        }

        public class Locators
        {
            public static readonly By Container = By.XPath("//div[@class='try-on-steps shadow-panel']");
            public static readonly By HeightSelect = By.Id("SelectedHeight");
            public static readonly By WeightSelect = By.Id("SelectedWeight");
            public static readonly By CoatSizeSelect = By.Id("SelectedCoatSizeId");
            public static readonly By FirstNameInputBox = By.Id("FirstName");
            public static readonly By LastNameInputBox = By.Id("LastName");
            public static readonly By AddressOneInputBox = By.Id("AddressEditor_NewAddress_Line1");
            public static readonly By AddressTwoInputBox = By.Id("AddressEditor_NewAddress_Line2");
            public static readonly By CityInputBox = By.Id("AddressEditor_NewAddress_City");
            public static readonly By StateSelect = By.Id("AddressEditor_NewAddress_StateCode");
            public static readonly By ZipInputBox = By.Id("AddressEditor_NewAddress_ZipCode");
            public static readonly By ConfirmDeliveryAddressButton = By.Id("ConfirmAddressButton");
            public static readonly By ConfirmDeliveryAddressButtonSpinner = By.XPath("//*[@id='ConfirmAddressButton' and contains(@class, 'spinner')]");
            public static readonly By SaveAsDefaultAddressCheckbox = By.Id("AddressEditor_NewAddressSaveAsDefault");
            public static readonly By ContactNumberInputBox = By.Id("ContactNumber");
            public static readonly By WeddingDateSelector = By.Id("EventDate");
            public static readonly By PreferredTryOnDateSelector = By.Id("TryOnDate_Value");
            public static readonly By CollectionDateLabel = By.Id("CollectionDateLabel");
            public static readonly By WeddingDateDatePickerContainer = By.Id("EventDate_dw_pnl_0");
            public static readonly By PreferredDateDatePickerContainer = By.Id("TryOnDate_Value_dw_pnl_0");
            public static readonly By ConfirmedAddressLabel = By.Id("ConfirmedAddressLabel");
            public static readonly By AddressConfirmationSpinner = By.XPath("//*[@class='button secondary-cta floatright large spinner']");
            public static readonly By SuggestedAddressLabel = By.Id("SuggestedAddress");

            public static readonly By ConfirmUserEnteredAddressButton = By.Id("ConfirmUserEnteredAddressButton");
            public static readonly By ConfirmSuggestedAddressButton = By.Id("ConfirmSuggestedAddressButton");

            public static readonly By InputNewAddressButton = By.Id("InputNewAddressButton");
            public static readonly By InvalidZipErrorLabel = By.XPath("//*[@class='field-validation-error']");
            
        }
    }
}
