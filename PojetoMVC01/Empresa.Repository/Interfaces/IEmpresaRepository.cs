using Empresa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
//using Empresa.Domain.Entities;  

namespace Empresa.Repository.Interfaces
{
    public interface IEmpresaRepository: IBaseRepository<EmpresaEntities>
    {
        EmpresaEntities ObterPorCnpj(string cnpj);
    }
}
