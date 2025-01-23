using System.Net.Http.Headers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Informe sua primeira nota:");
        double primeiraNota = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe sua segunda nota:");
        double segundaNota = Convert.ToDouble(Console.ReadLine());
        double media = (primeiraNota + segundaNota) / 2. ;
        Console.WriteLine("Sua média é: " + media);
        }
    }
}

