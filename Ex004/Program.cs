namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1, num3;
            float resposta, num4;
            Console.WriteLine("Digite um numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num3 = num - num1;
            Console.WriteLine("A subtração de {0} - {1} é: {2}", num, num1, num3);

            num3 = num + num1;
            Console.WriteLine("A soma de {0} + {1} é: {2}", num, num1, num3);

            num3 = num * num1;
            Console.WriteLine("A multiplicação de {0} * {1} é: {2}", num, num1, num3);

            Console.WriteLine("Digite um numero: ");
            num4 = Convert.ToInt32(Console.ReadLine()); 

            resposta = num / num4;
            Console.WriteLine("A divisão de {0} / {1} é: {2}", num, num4, resposta);

            resposta = num % num1;
            Console.WriteLine("O resto da divisão de {0} / {1} é: {2}", num, num1, resposta);

        }
    }
}
