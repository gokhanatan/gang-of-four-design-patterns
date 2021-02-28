namespace AbstractFactory
{
    public class BlackBackgroundColor : IBackgroundColor
    {
        public void SetBackgroundColor()
        {
            System.Console.WriteLine("Background color was setted black.");
        }
    }
}