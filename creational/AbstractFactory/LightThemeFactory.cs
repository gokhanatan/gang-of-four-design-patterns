namespace AbstractFactory
{
    public class LightThemeFactory : IThemeFactory
    {
        public IBackgroundColor CreateBackgorundColor()
        {
            return new WhiteBackgroundColor();
        }

        public ITextColor CreateTextColor()
        {
            return new BlackTextColor();
        }
    }
}