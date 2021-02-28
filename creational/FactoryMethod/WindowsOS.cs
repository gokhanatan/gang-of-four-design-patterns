namespace FactoryMethod
{
    public class WindowsOS : IOperationSystem
    {
        public void Start()
        {
            System.Console.WriteLine("It is a Windows OS");
        }
    }
}