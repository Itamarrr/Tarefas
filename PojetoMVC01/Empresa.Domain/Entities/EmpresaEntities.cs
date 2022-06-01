using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Domain.Entities
{
    public class EmpresaEntities
    {
        #region Propriedades
        public Guid IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        #endregion
        #region Relacionamentos Empresa Funcionario 
        //associação uma empresa tem varios funcionarios
        List<FuncionarioEntities> Funcionarios { get; set; }
        #endregion
    }
}
