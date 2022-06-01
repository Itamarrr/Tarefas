using Empresa.Domain.Entities;
using Empresa.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Repository.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {

        public void Inserir(EmpresaEntities obj)
        {
            throw new NotImplementedException();
        }

        public void Alterar(EmpresaEntities obj)
        {
            throw new NotImplementedException();
        }

        public void Exluir(EmpresaEntities obj)
        {
            throw new NotImplementedException();
        }
       

        public EmpresaEntities ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public EmpresaEntities ObterPorCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }

        public List<EmpresaEntities> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
