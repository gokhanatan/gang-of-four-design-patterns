namespace AbstractFactory
{
    public class WhiteBackgroundColor : IBackgroundColor
    {
        public void SetBackgroundColor()
        {
            System.Console.WriteLine("Background color was setted white.");
        }
    }
}