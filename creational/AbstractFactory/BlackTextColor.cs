namespace AbstractFactory
{
    public class BlackTextColor : ITextColor
    {
        public void SetTextColor()
        {
            System.Console.WriteLine("Text color was setted black.");
        }
    }
}