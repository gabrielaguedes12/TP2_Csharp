namespace exercicio_08_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma nota de 0 a 10: ");
            double nota = double.Parse(Console.ReadLine());

            string classificacao;

            if (nota < 0 || nota > 10)
            {
                classificacao = "Nota inválida!";
            }
            else if (nota < 5)
            {
                classificacao = "Insuficiente";
            }
            else if (nota < 7)
            {
                classificacao = "Regular";
            }
            else if (nota < 9)
            {
                classificacao = "Bom";
            }
            else
            {
                classificacao = "Excelente";
            }

            Console.WriteLine($"\nClassificação: {classificacao}");
        }
    }
}