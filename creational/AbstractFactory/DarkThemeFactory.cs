namespace AbstractFactory
{
    public class DarkThemeFactory : IThemeFactory
    {
        public IBackgroundColor CreateBackgorundColor()
        {
            return new BlackBackgroundColor();
        }

        public ITextColor CreateTextColor()
        {
            return new WhiteTextColor();
        }
    }
}