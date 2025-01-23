namespace Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um final para parar a contagem: ");
            int final = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < final; i++){
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
    }   }
}