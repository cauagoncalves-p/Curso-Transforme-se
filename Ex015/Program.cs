namespace Ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma, cont;
            soma = cont = 0;

            for (int i = 1; i <= 500; i++) {
                if (i % 3 == 0)
                {
                    soma += i;
                    cont++;
                }   
            }
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Contador: {cont}");
        }
    }
}
