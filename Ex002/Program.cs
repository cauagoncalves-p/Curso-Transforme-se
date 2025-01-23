namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 45;
            float num = 14.5f;
            char letra = 'a';
            string palavra = "ola";
            Console.WriteLine("O numero é {0}", numero);
            Console.WriteLine("O numero decimal é {0}", num);
            Console.WriteLine("O caracter é o {0}", letra);
            Console.WriteLine("A palavra é {0}", palavra);

            Console.WriteLine("O numero é {0}, o numero decimal é o {1}, o caracter é o '{2}', a palavra é '{3}'", numero, num, letra, palavra);
        }
    }
}
