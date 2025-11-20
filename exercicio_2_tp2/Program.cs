using System;

namespace exercicio_02_tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua data de nascimento: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            DateTime hoje = DateTime.Today;

            DateTime proximoAniversario = new DateTime(
              hoje.Year,
              dataNascimento.Month,
              dataNascimento.Day
                );

           
        }
    }
}
