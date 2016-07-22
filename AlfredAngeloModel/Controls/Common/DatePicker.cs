﻿using CommonModel.Controls.Common;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace AlfredAngeloModel.Controls.Common
{
    public class DatePicker : BaseDatePicker
    {
        public DatePicker(TestSettings testSettings, IWebElement element) : base(testSettings, element)
        {
        }
    }
}