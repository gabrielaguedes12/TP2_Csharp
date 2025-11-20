namespace exercicio_12_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int palpite = 0;

            Console.WriteLine("Jogo de Adivinhação! Tente acertar o número de 1 a 100.\n");

            while (palpite != numeroSecreto)
            {
                Console.Write("Digite seu palpite: ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Muito alto! Tente novamente.\n");
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo! Tente novamente.\n");
                }
                else
                {
                    Console.WriteLine("\n🎉 Parabéns! Você acertou o número!");
                }
            }
        }
    }
}