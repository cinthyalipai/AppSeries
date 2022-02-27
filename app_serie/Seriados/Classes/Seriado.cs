namespace Seriados
{
    public class Seriado : AtribuiCodigo
    {
        //Atributos

        private Decada Decada { get; set; }
        private string Titulo { get; set; }
        private string Ator { get; set; }
        private int Temporadas { get; set; }
        private string Resenha { get; set; }
        private bool Deletado {get; set; }
    

        public Seriado(int id, Decada decada, string titulo, string ator, int temporadas, string resenha)
        {
            this.Id = id;
            this.Decada = decada;
            this.Titulo = titulo;
            this.Ator = ator;
            this.Temporadas = temporadas;
            this.Resenha = resenha;
            this.Deletado = false;
        }

        public override string ToString()
        {
            string retornar = " ";
            retornar += "Década de Lançamento: " + this.Decada + Environment.NewLine;
            retornar += "Título: " + this.Titulo + Environment.NewLine;
            retornar += "Ator(Atriz) Principal: " + this.Ator + Environment.NewLine;
            retornar += "Numero Temporadas: " + this.Temporadas + Environment.NewLine;
            retornar += "Resenha: " + this.Resenha + Environment.NewLine;
            retornar += "Ativo no Estoque: " + this.Deletado + Environment.NewLine;
            return retornar;
        }

        public string devolveTitulo()
        {
            return this.Titulo;
        }

        public int devolveId()
        {
            return this.Id;
        }

        public void BaixaEstoque()
        {
            this.Deletado = true;
        }
    }    
}