using Empresa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Repository.Interfaces
{
    public interface IFuncionarioRepository: IBaseRepository<FuncionarioEntities>
    {
        FuncionarioEntities ObterPorCpf(string cpf);
        FuncionarioEntities ObterPorMatricula(string matricula);
    }
}
