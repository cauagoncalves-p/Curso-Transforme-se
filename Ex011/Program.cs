namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("Digite o valor do lado A: ");
            ladoA = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            ladoB = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            ladoC = int.Parse(Console.ReadLine());

            // Verifica se os lados formam um triângulo
            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valores informados formam um triângulo.");

                // Identifica o tipo de triângulo
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores informados NÃO formam um triângulo.");
            }
        }
    }
}
