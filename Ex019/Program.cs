namespace Ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vetores

            //int[] numero = new int[5];


            //numero[0] = 10;
            //numero[1] = 20;
            //numero[2] = 30;
            //numero[3] = 40;
            //numero[4] = 50;

            //Console.WriteLine(numero[0]);
            //Console.WriteLine(numero[1]);

            //int[] numero1 = new int[5] { 10, 20, 30, 40, 50 };
            //Console.WriteLine(numero1[4]);

            //int[] vetores = { 1, 2, 3, 4, 5, 98, 7184, 8, 9, 10 };
            //Console.WriteLine(vetores[7]);

            //for (int i = 0; i < vetores.Length; i++) {

            //    Console.WriteLine(vetores[i]);
            //}

            //double[] reais = { 4.5, 4.8, 4.9, 1.7, 10.5, 10.9 };
            //for (int i = 0; i < reais.Length; i++)
            //{

            //    Console.WriteLine(reais[i]);
            //}

            //double reais_maior = reais.Max();
            //double reais_menor = reais.Min();

            //Console.WriteLine("O maior numero é" + reais_maior);
            //Console.WriteLine("O maior numero é" + reais_menor);

            string[] nomes = { "caua", "pedro", "maria", "marcos", "zeferina" };
            for (int i = 0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1)
                {
                    Console.Write(nomes[i] + ", ");
                }
                else {
                    Console.WriteLine(nomes[i] + ".");
                }
            }

            Console.WriteLine();

            string nomePrimeiro = nomes.First();
            string nomeUltimo = nomes.Last();

            Console.WriteLine("O primeiro nome é: " + nomePrimeiro);
            Console.WriteLine("O ultimo nome é:" + nomeUltimo);

            Console.WriteLine();

            // Ordem alfabetica

            string primeiroNomeOrdemAlfabetica = nomes.Min();
            string ultimoNomeOrdemAlfabetica = nomes.Max();

            Console.WriteLine("O primeiro nome em ordem Alfabética é : " + primeiroNomeOrdemAlfabetica);
            Console.WriteLine("O Ultimo nome em ordem Alfabética é : " + ultimoNomeOrdemAlfabetica); ;

            Console.WriteLine();


        }
    }
}
