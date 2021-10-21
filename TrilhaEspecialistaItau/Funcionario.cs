using System;
using System.Collections.Generic;
using System.Text;

namespace TrilhaEspecialistaItau
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public double ValorHora { get; set; }

        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;
        }
        public Funcionario() { }
        public double Salario
        {
            get { return CalcularSalario(CargaHoraria, ValorHora); }
            set { }
        }
        public virtual double CalcularSalario(int cargaHoraria, double valorHora)
        {
            return  cargaHoraria * valorHora;
        }

        public virtual void ImprimirDados(Funcionario funcionario)
        {
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Salário: R${funcionario.Salario}");
            Console.WriteLine();
        }
    }
}
