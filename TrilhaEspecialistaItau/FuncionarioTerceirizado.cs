using System;
using System.Collections.Generic;
using System.Text;

namespace TrilhaEspecialistaItau
{
    internal class FuncionarioTerceirizado : Funcionario
    {
        public string EmpresaOrigem { get; set; }
        public double TaxaServiço { get; set; }

        public FuncionarioTerceirizado() { }

        public FuncionarioTerceirizado(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServiço)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;
            EmpresaOrigem = empresaOrigem;
            TaxaServiço = taxaServiço;
        }

        public override double CalcularSalario(int cargaHoraria, double valorHora)
        {
            double salario = base.CalcularSalario(cargaHoraria, valorHora);
            double adicional = salario * this.TaxaServiço;
            return salario + adicional;
        }

        public override void ImprimirDados(Funcionario funcionario)
        {
            Console.WriteLine($"Nome: {base.Nome}");
            Console.WriteLine($"Empresa Origem: {EmpresaOrigem}");
            Console.WriteLine($"Salário: R${this.Salario}");
            Console.WriteLine();
        }
    }
}
