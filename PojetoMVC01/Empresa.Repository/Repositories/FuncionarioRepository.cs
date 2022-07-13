using Dapper;
using Empresa.Domain.Entities;
using Empresa.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Empresa.Repository.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        
        private string connectionstring;
        public void Inserir(FuncionarioEntities obj)
        {
            var query = @"INSERT INTO FUNCIONARIO (IDFUNCIONARIO, NOME, CPF, MATRICULA, DATAADMISSAO, IDEMPRESA)";

            using (var connection= new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }


        public void Alterar(FuncionarioEntities obj)
        {
            var query = @"UPDATE FUNCIONARIO SETE MATRICULA = @MATRICULA 
                          WHERE IDFUNCIONARIO = IDFUNCIONARIO AND IDEMPRESA = IDEMPRESA";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Exluir(FuncionarioEntities obj)
        {
            var query = @"DELETE * FROM  FUNCIONARIO WHERE IDFUNCIONARIO = @IDFUNCIONARIO AND IDEMPRESA = @IDEMPRESA";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

      
        public FuncionarioEntities ObterPorCpf(string cpf)
        {
            var @"SELECT * FROM FUNCIONARIO WHERE CPF = @cpf";

            using (var connection = new SqlConnection(connectionstring))
            {
               return connection.Query(connectionstring(new ))
            }
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
