namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distância percorrida: ");
            double velocidade = Convert.ToDouble(Console.ReadLine());
            string informacao;
            if (velocidade >= 80) {
                double multa = (velocidade - 80) * 7.00;
                informacao = $"Você foi multado em R$ {multa}";
            }
            else {
                informacao = "Você está a um limite de velocidade seguro";
            }

            Console.WriteLine("Informação de velocidade: {0}", informacao);

        }
    }
}
