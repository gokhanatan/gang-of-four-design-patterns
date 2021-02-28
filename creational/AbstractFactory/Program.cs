using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Theme theme = new Theme(new DarkThemeFactory());
            theme.ApplyTheme();

            System.Console.WriteLine("----------------------");
            
            theme = new Theme(new LightThemeFactory());
            theme.ApplyTheme();
        }
    }
}
