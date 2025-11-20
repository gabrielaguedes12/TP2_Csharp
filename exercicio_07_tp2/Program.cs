namespace exercicio_07_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("\nO número é PAR.");
            else
                Console.WriteLine("\nO número é ÍMPAR.");
        }
    }
}