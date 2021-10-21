using System;
using System.Collections.Generic;

namespace TrilhaEspecialistaItau
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Pedro", 8, 250.0);
            funcionario1.CalcularSalario(funcionario1.CargaHoraria, funcionario1.ValorHora);
            funcionario1.ImprimirDados(funcionario1);

            Funcionario funcionario2 = new Funcionario();
            funcionario2.Nome = "Tiago";
            funcionario2.CargaHoraria = 8;
            funcionario2.ValorHora = 450;
            funcionario2.CalcularSalario(funcionario2.CargaHoraria, funcionario2.ValorHora);
            funcionario2.ImprimirDados(funcionario2);

            Funcionario funcionario3 = new FuncionarioTerceirizado("João", 8, 450, "Indra Company", 0.10);
            funcionario3.CalcularSalario(funcionario3.CargaHoraria, funcionario3.ValorHora);
            funcionario3.ImprimirDados(funcionario3);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Funcionário é terceirizado? Sim : s / Não : n");
                string tercerizado = Console.ReadLine();
                switch (tercerizado)
                {
                    case "s":
                        FuncionarioTerceirizado f = new FuncionarioTerceirizado();
                        Console.WriteLine("Qual o Nome?");
                        f.Nome = Console.ReadLine();
                        Console.WriteLine("Qual a Carga Horária?");
                        f.CargaHoraria = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Qual o Valor da Hora?");
                        f.ValorHora = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual a Empresa Origem?");
                        f.EmpresaOrigem = Console.ReadLine();
                        Console.WriteLine("Qual a Taxa de Serviço?");
                        f.TaxaServiço = Convert.ToDouble(Console.ReadLine());

                        f.CalcularSalario(f.CargaHoraria, f.ValorHora);
                        f.ImprimirDados(f);
                        break;

                    case "n":
                        Funcionario f2 = new Funcionario();
                        Console.WriteLine("Qual o Nome?");
                        f2.Nome = Console.ReadLine();
                        Console.WriteLine("Qual a Carga Horária?");
                        f2.CargaHoraria = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Qual o Valor da Hora?");
                        f2.ValorHora = Convert.ToDouble(Console.ReadLine());

                        f2.CalcularSalario(f2.CargaHoraria, f2.ValorHora);
                        f2.ImprimirDados(f2);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
