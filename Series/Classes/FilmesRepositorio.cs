using System;
using System.Collections.Generic;
using Series.Classes;
using Series.Interfaces;

namespace Series
{
    public class FilmesRepositorio : IRepositorio<Filmes>
    {
        
        private List<Filmes> listaFilmes = new List<Filmes>();

        public FilmesRepositorio(int id, Genero genero, string? titulo, int ano, string? descricao)
        {
        }

        public void Atualiza(int id, Serie entidade)
        {
            listaFilmes[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaFilmes[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaFilmes.Add(objeto);
        }

        public List<Filmes> GetListaFilmes()
        {
            return listaFilmes;
        }

        public List<Serie> Lista(List<Serie> listaFilmes)
        {
            return listaFilmes;
        }

        public int ProximoId()
        {
            return listaFilmes.Count;
        }

        public Filmes RetornaPorId(int id)
        {
            return listaFilmes[id];
        }

        public List<Filmes> Lista()
        {
            throw new NotImplementedException();
        }

        Filmes IRepositorio<Filmes>.RetornaPorIds(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Filmes entidade)
        {
            throw new NotImplementedException();
        }

        public void Atualiza(int id, Filmes entidade)
        {
            throw new NotImplementedException();
        }

        public List<Filmes> ListaFilmes()
        {
            throw new NotImplementedException();
        }

        public Filmes RetornaPorIds(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Filmes entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(int id, Filmes entidade)
        {
            throw new NotImplementedException();
        }

        public int ProximoIds()
        {
            throw new NotImplementedException();
        }
    }
}