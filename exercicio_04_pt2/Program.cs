namespace exercicio_04_pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Frmulário de Cadastro==");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu idade: ");
            string idade = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("==Cadastro==");
            Console.WriteLine($"Nome:     {nome}");
            Console.WriteLine($"Idade:     {idade}");
            Console.WriteLine($"Telefone:     {telefone}");
            Console.WriteLine($"E-mail:     {email}");

        }
    }
}
