namespace Ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número que você quer ver a tabuada: ");
            int tab = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número que você quer que va a tabuada: ");
            int total = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= total; i++)
            {
                int resultado = tab * i;
                Console.WriteLine("{0} X {1} = {2} ", tab, i, resultado);
            }
        }
    }
}