namespace Ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Teste Senha 

            string senha = "123";
            string senhaDigitada;
            int tentativas = 0;

            do {
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;
                if (tentativas > 3) { break; }
            } while (senha != senhaDigitada);

            if (senha != senhaDigitada)
            {
                Console.Clear();
                Console.WriteLine("Senha incorreta! Tentativas: " + tentativas);
            }
            else {
                Console.Clear();
                Console.WriteLine("Senha Correta! Tentativas:" + tentativas);
            }
           
            
        }
    }
}
