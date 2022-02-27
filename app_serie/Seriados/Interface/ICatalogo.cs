using System.Collections.Generic;

namespace Seriados.Interface
{
    public interface ICatalogo<T>
    {
         List<T> Catalogo();
         T RetornaItem (int id);
         void Inserir(T entidade);
         void Excluir(int id);
         void Atualizar(int id, T entidade);
         int ProximoItem();

    }
}