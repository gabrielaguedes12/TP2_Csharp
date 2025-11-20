namespace exercicio_10_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para a contagem regressiva: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("\nContagem: ");

            for (int i = numero; i >= 0; i--)
            {
                if (i > 0)
                    Console.Write(i + ", ");
                else
                    Console.Write(i);
            }
        }
    }
}