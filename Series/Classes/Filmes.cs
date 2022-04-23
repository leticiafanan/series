namespace Series.Classes
{
    public class Filmes : EntidadeBase
    {
        private Genero genero;

        private string Genero { get ; set; }

        private string Titulo { get ; set; }

        private string Descricao { get ; set; }

        private int Ano { get ; set; }

        private bool Excluido {get ; set;}

        public Filmes(int id, string genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public Filmes(int id, Genero genero, string? titulo, int ano, string? descricao)
        {
            Id = id;
            this.genero = genero;
            Titulo = titulo;
            Ano = ano;
            Descricao = descricao;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;

        }
         
        public bool retornaExcluido()
        {
            return this.Excluido;

        }
        public void Excluir()
        {
            this.Excluido = true;
        }

        public static implicit operator Filmes(Serie v)
        {
            throw new NotImplementedException();
        }
    }
}