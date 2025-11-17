using System;

namespace exercicio_01_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua data de nascimento: ");

            string entrada = Console.ReadLine();
            DateTime dataUsuario = DateTime.Parse(entrada);

            DateTime hoje = DateTime.Today;

            int anos = hoje.Year - dataUsuario.Year;

            if (dataUsuario.Date > hoje.AddYears(-anos))
            {
                anos--;
            }

            int meses = hoje.Month - dataUsuario.Month;
            if (hoje.Day < dataUsuario.Day)
                meses--;

            if (meses < 0)
                meses += 12;

            int dias;

            if (hoje.Day >= dataUsuario.Day)
            {
                dias = hoje.Day - dataUsuario.Day;
            }
            else
            {
                DateTime mesAnterior = hoje.AddMonths(-1);
                int diasNoMesAnterior = DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month);
                dias = diasNoMesAnterior - dataUsuario.Day + hoje.Day;
            }

            Console.WriteLine($"Idade exata: {anos} anos, {meses} meses e {dias} dias.");
        }
    }
}
