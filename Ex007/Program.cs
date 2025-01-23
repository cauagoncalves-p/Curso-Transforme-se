namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1,n2,n3,n4;
            string resultado;

            Console.Write("Digite a primeira nota do Aluno : ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Segunda nota do Aluno : ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Terceira nota do Aluno : ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Quarta nota do Aluno : ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2 + n3 + n4) / 4;

            if (nota_final > 70)
            {
                resultado = "Aprovado";
                if (nota_final >= 90)
                {
                    resultado = "Aprovado com louvor";
                }  
            }
            else if (nota_final >= 45) {
                resultado = "Recuperação";   
            }
            else
            {
                resultado = "Reprovado";    
            }

            Console.WriteLine(resultado);
        }
    }
}
