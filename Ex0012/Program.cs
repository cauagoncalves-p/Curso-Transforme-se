using System.ComponentModel.Design;

namespace Ex0012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu salario: ");
            double salario =  double.Parse(Console.ReadLine());
            double aumento, valorAtual;
            if (salario > 2500.00)
            {
                aumento = salario * 0.05;
                valorAtual = salario + aumento;
                Console.Write("Você teve um aumente de 5% no seu salário, o valor atual dele é de R$: {0}", valorAtual);
            }
            else if (salario > 1250)
            {
                aumento = salario * 0.10;
                valorAtual = salario + aumento;
                Console.Write("Você teve um aumente de 10% no seu salário, o valor atual dele é de R$: {0}", valorAtual);
            }
            else {
                aumento = salario * 0.15;
                valorAtual = salario + aumento;
                Console.Write("Você teve um aumente de 15% no seu salário, o valor atual dele é de R$: {0}", valorAtual);
            
            }
        }
    }
}
