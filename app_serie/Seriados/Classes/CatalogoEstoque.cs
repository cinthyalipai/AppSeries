using System;
using System.Collections.Generic;
using Seriados.Interface;

namespace Seriados
{
    public class CatalogoEstoque : ICatalogo<Seriado>
    {
        private List<Seriado> catalogo = new List<Seriado>();
        public void Atualizar(int id, Seriado item)
        {
            catalogo[id] = item;
        }

        public List<Seriado> Catalogo()
        {
            return catalogo;
        }

        public void Excluir(int id)
        {
            catalogo[id].BaixaEstoque();
        }

        public void Inserir(Seriado item)
        {
            catalogo.Add(item);
        }

        public int ProximoItem()
        {
            return catalogo.Count();
        }

        public Seriado RetornaItem(int id)
        {
            return catalogo[id];
        }
    }
}