namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            string resultado;
            if (numero % 2 == 0)
            {
                resultado = "O numero: {0} é Par";
            }
            else {
                resultado = "O numero: {0} é Impar";
        }
            Console.WriteLine(resultado, numero);
        }
    }
}
