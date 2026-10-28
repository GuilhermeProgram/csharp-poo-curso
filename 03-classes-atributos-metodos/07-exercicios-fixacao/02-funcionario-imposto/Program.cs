using system;
using system.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Entre com os dados do funcionário:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionario.Nome + ", $ " + funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario.Nome + ", $ " + funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}