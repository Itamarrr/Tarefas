using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Repository.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Inserir(T obj);
        void Alterar(T obj);
        void Exluir(T obj);


        List<T>ObterTodos();
        T ObterPorId(Guid id);
    }
}
