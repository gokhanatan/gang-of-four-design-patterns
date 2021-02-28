namespace FactoryMethod
{
    public class MacOS : IOperationSystem
    {
        public void Start()
        {
            System.Console.WriteLine("It is a MacOS");
        }
    }
}