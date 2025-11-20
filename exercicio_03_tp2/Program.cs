namespace exercicio_03_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira data (dd/mm/aaaa): ");
            DateTime data1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segundaa data (dd/mm/aaaa): ");
            DateTime data2 = DateTime.Parse(Console.ReadLine());

            if (data1 > data2)
            {
                DateTime temp = data1;
                data1 = data2;
                data2 = temp;
            }

                int anos = data2.Year - data1.Year;
                int meses = data2.Month -data1.Month;
                int dias = data2.Day - data1.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(data2.AddMonths(-1).Year, data2.AddMonths(-1).Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }
            TimeSpan intervalo = data2 - data1;
            int totalDias = intervalo.Days;

            Console.WriteLine("\n===== Diferença Entre as Datas =====");
            Console.WriteLine($"Anos:  {anos}");
            Console.WriteLine($"Meses: {meses}");
            Console.WriteLine($"Dias:  {dias}");
            Console.WriteLine($"Total em dias: {totalDias}");
        }
    }
}
