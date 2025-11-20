namespace exercicio_05_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 9/5 + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"O número em Fahrenheit é: {fahrenheit :F2} °F");
            Console.WriteLine($"Temperatura em Kelvin: {kelvin:F2} K");
        }
    }
}
