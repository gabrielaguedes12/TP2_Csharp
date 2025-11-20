namespace exercicio_06_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}");

            string classificacao;

            if (imc < 18.5)
                classificacao = "Abaixo do peso";
            else if (imc < 25)
                classificacao = "Peso normal";
            else if (imc < 30)
                classificacao = "Sobrepeso";
            else if (imc < 35)
                classificacao = "Obesidade Grau I";
            else if (imc < 40)
                classificacao = "Obesidade Grau II";
            else
                classificacao = "Obesidade Grau III";

            Console.WriteLine($"Classificação: {classificacao}");
        }
    }
}