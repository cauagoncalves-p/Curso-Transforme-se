namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Vetores

            string[] frutas = { "Maça", "Banana", "Uva", "Pera", "Morango", "Melão", "Melancia", "Abacaxi", "Jáca", "Kiwi" };
            double[] precos = { 10.80, 7.99, 8.75, 12.98, 15.08, 12.00, 9.99, 10.00, 4.95, 7.45 };

            // Palavra em ordem alfabetica
            string pAlafabetica = frutas.Min();
            Console.WriteLine("A Primeira palavra em ordem crescente é: " + pAlafabetica);
            string uAlfabetica = frutas.Max();
            Console.WriteLine("A Última palavra em ordem crescente é: " + uAlfabetica);
            Console.WriteLine();
            // Preços maior e menor
            double menorPreco = precos.Min();
            Console.WriteLine("O menor preço das frutas é: R$: " + menorPreco);
            double maiorPreco = precos.Max();
            Console.WriteLine("O Maior preço das frutas é: R$ " + maiorPreco);
            Console.WriteLine();

            // Juntando os vetores
            for (int i = 0; i < frutas.Length; i++) {
                Console.WriteLine("A fruta é: {0} e ela custa R${1}", frutas[i], precos[i]);
            }
        }
    }
}
