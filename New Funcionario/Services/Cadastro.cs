using System;
using System.Collections.Generic;
using New_Funcionario.Entities;

namespace New_Funcionario.Services
{
    class Operacoes
    {
        public static void Cadastro()
        {
            try
            {
                Console.WriteLine("Nome do gerente que deseja acessar: ");
                string gerente = Console.ReadLine();
                Chefe chefe = new Chefe(gerente);
                Console.Clear();
                Console.Write("Informe a quantidade de empregados a serem cadastrados: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.Clear();
                    Console.Write("\n\n" + i + "º Empregado\n");
                    Console.Write("\nInforme o ID do funcionário: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Informe o nome: ");
                    string nome = Console.ReadLine();
                    while (nome.Length <= 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Informe um nome válido, com no mínimo 2 letras!\n");
                        Console.ResetColor();
                        Console.Write("Informe o nome: ");
                        nome = Console.ReadLine();
                    }
                    Console.Write("Informe o salário: ");
                    double salario = double.Parse(Console.ReadLine());
                    DateTime horario = DateTime.Now;
                    chefe.AddEmpregado(new Empregado(id, nome, salario, horario));
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInsira as informações corretamente! \n\n");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Cadastro();
            }
        }
    }
}
