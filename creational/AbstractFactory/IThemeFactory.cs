namespace AbstractFactory
{
    public interface IThemeFactory
    {
        IBackgroundColor CreateBackgorundColor();
        ITextColor CreateTextColor();
    }
}