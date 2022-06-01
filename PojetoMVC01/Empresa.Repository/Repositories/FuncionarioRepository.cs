using Empresa.Domain.Entities;
using Empresa.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Repository.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        public void Alterar(FuncionarioEntities obj)
        {
            throw new NotImplementedException();
        }

        public void Exluir(FuncionarioEntities obj)
        {
            throw new NotImplementedException();
        }

        public void Inserir(FuncionarioEntities obj)
        {
            throw new NotImplementedException();
        }

        public FuncionarioEntities ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public FuncionarioEntities ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public FuncionarioEntities ObterPorMatricula(string matricula)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioEntities> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
