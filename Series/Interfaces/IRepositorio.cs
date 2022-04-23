using System.Collections.Generic;

namespace Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> ListaFilmes();

         T RetornaPorIds(int id);

         void Inserir(T entidade);

         void Excluir(int id);

         void Atualizar(int id, T entidade);

         int ProximoIds();
    }

    public interface IRepositorios<T>
    {
         List<T> ListaSeries();

         T RetornaPorId(int id);

         void Insere(T entidade);

         void Exclui(int id);

         void Atualiza(int id, T entidade);

         int ProximoId();
    }
}