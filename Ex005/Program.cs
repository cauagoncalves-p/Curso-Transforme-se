namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite um numero para ver sua tabuada: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            //int total = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("{0} X {1} = {2}", numero, 1, numero * 1);
            Console.WriteLine("{0} X {1} = {2}", numero, 2, numero * 2);
            Console.WriteLine("{0} X {1} = {2}", numero, 3, numero * 3);
            Console.WriteLine("{0} X {1} = {2} ",numero, 4, numero * 4);
            Console.WriteLine("{0} X {1} = {2}", numero, 5, numero * 5);
            Console.WriteLine("{0} X {1} = {2}", numero, 6, numero * 6);
            Console.WriteLine("{0} X {1} = {2}", numero, 7, numero * 7);
            Console.WriteLine("{0} X {1} = {2}", numero, 8, numero * 8);
            Console.WriteLine("{0} X {1} = {2}", numero, 9, numero * 9);
            Console.WriteLine("{0} X {1} = {2}", numero, 10,numero * 10);





            //Console.WriteLine("A tabuada do seu numero ");
            //for (int i = 0; i <= total; i++) {
            //    int resultado = numero * i;
            //    Console.WriteLine("{0} X {1} = {2}", numero, i, resultado);                                                       

            //   }


        }
    }
}
