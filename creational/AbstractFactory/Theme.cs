namespace AbstractFactory
{
    public class Theme
    {
        private readonly IThemeFactory _themeFactory;
        private readonly IBackgroundColor _backgroundColor;
        private readonly ITextColor _textColor;

        public Theme(IThemeFactory themeFactory)
        {
            _themeFactory = themeFactory;

            _backgroundColor = _themeFactory.CreateBackgorundColor();
            _textColor = _themeFactory.CreateTextColor();
        }

        public void ApplyTheme()
        {
            _backgroundColor.SetBackgroundColor();
            _textColor.SetTextColor();
        }
    }
}