using System;
using System.Collections.Generic;
using System.Text;

namespace New_Funcionario.Entities
{
    class Chefe
    {
        public string Empresa { get; set; }
        public List<Empregado> Empregados { get; set; }

        public Chefe(string empresa)
        {
            Empresa = empresa;
            Empregados = new List<Empregado>();
        }
        public void AddEmpregado(Empregado empregado)
        {
            Empregados.Add(empregado);
        }
    }
}
