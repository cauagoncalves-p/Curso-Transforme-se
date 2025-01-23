namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distância em KM: ");
            double distancia = Convert.ToDouble(Console.ReadLine());
            double preco;
            string informacao;
            if (distancia > 200)
            {
                preco = distancia * 0.45;
                informacao = "A distância ultrapassa 200KM, sendo assim, o valor da passagem fica em: R$ {0}";
            }
            else {
                preco = distancia * 0.50;
                informacao = "A distância não ultrapassa 200KM, sendo assim, o valor da passagem fica em: R$ {0}";
            }

            Console.WriteLine(informacao, preco);
        }
    }
}
