using System;
using System.Collections.Generic;
using Series.Interfaces;

namespace Series
{
    public class SerieRepositorio : IRepositorios<Serie>
    {
        
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public List<Serie> ListaSeries()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        internal object GetListaSeries()
        {
            throw new NotImplementedException();
        }

        internal void Insere(FilmesRepositorio novoFilme)
        {
            throw new NotImplementedException();
        }
    }
}