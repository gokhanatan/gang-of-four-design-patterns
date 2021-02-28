namespace AbstractFactory
{
    public class WhiteTextColor : ITextColor
    {
        public void SetTextColor()
        {
            System.Console.WriteLine("Text color was setted white.");
        }
    }
}