using System;
using System.Collections.Generic;
using System.Text;

namespace New_Funcionario.Entities
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public DateTime Horario { get; set; }

        public Empregado(int id, string nome, double salario, DateTime horario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
            Horario = horario;
        }
    }
}
