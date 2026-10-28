using System;
namespace Course
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(Double porcetagem)
        {
            Salario = Salario + (Salario * porcetagem / 100.0);
        }
    }
}