using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Domain.Entities
{
    public class Funcionario
    {
        #region Propriedades
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Guid IdEmpresa { get; set; }
        #endregion

        #region Relacionamentos Funcionario Empresa
        //associação um funcionario tem uma empresa
        public Empresa Empresa { get; set; }
        #endregion
    }
}
