using Dapper;
using Empresa.Domain.Entities;
using Empresa.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Empresa.Repository.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        //Atributo
        private string connectionstring;

        public EmpresaRepository(string connectionstring)
        {
            this.connectionstring = connectionstring; 
        }

        public void Inserir(EmpresaEntities obj)
        {
            var query = @"INSERT INTO EMPRESA(IDEMRESA, RAZAOSOCIAL, CNPJ)
                            VALUES(@IDEMPRESA, @RAZAOSOCIAL, @CNPJ)";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
           
        }

        public void Alterar(EmpresaEntities obj)
        {
            var query = @"UPDATE EMPRESA SETE RAZAOSOCIAL = @RAZAOSOCIAL
                          WHERE IDEMPRESA = @IDEMPRESA";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Exluir(EmpresaEntities obj)
        {
            var query = @"DELETE FROM EMPRESA WHERE IDEMPRESA = @IDEMPRESA";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }
        public List<EmpresaEntities> ObterTodos()
        {
            var query = @"SELECT * FROM EMPRESA ORDER BY RAZAOSOCIAL ";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<EmpresaEntities>(query).ToList();
            }
        }
        public EmpresaEntities ObterPorId(Guid id)
        {
            var query = @"SELECT * FROM EMPRESA WHERE IDEMPRESA = @id";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<EmpresaEntities>(query, new {id}).FirstOrDefault();
            }
        }

        public EmpresaEntities ObterPorCnpj(string cnpj)
        {
            var query = @"SELECT * FROM WHERE CNPJ = @cnpj";
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<EmpresaEntities>(query, new {cnpj}).FirstOrDefault();
            }
        }

      
    }
}
