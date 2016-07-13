using OpenQA.Selenium;

namespace Core.CustomElements
{
    public class ColourSelector
    {
        private IWebElement _element;

        public ColourSelector(IWebElement element)
        {
            _element = element;
        }

        public string Name
        {
            get { return _element.GetAttribute("data-colour-desc"); }
        }

        public string Code
        {
            get
            {
                var str = _element.GetCssValue(("background-color"));
                var numbers = str.Replace("rgba(", "").Replace(")", "").Split(',');
                var r = numbers[0].Trim();
                var g = numbers[1].Trim();
                var b = numbers[2].Trim();
                return string.Format("#%02x%02x%02x", r, g, b);
            }
        }

        public bool Selected
        {
            get { return _element.GetAttribute("class").Contains("selected"); }
        }

        public void Select()
        {
            if (!Selected)
            {
                _element.Click();
            }
        }

        public void Deselect()
        {
            if (Selected)
            {
                _element.Click();
            }
        }
    }
}
