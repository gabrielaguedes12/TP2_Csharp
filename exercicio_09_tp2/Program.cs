namespace exercicio_09_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            double imposto;

            if (salarioBruto <= 2000)
            {
                imposto = 0;
            }
            else if (salarioBruto <= 3500)
            {
                imposto = salarioBruto * 0.10;
            }
            else if (salarioBruto <= 5000)
            {
                imposto = salarioBruto * 0.15;
            }
            else
            {
                imposto = salarioBruto * 0.20;
            }

            double salarioLiquido = salarioBruto - imposto;

            Console.WriteLine("\n===== Cálculo Salarial =====");
            Console.WriteLine($"Salário Bruto:   R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto Imposto: R$ {imposto:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
        }
    }
}