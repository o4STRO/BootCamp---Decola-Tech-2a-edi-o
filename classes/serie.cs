namespace appCadastroDeSeries_desafioDecolaTech2aEdicao
{
    public class serie : entididadeBase
    {

//atributos
        private genero genero { get; set; }

        private string titulo { get; set; }

        private string descricao { get; set; }

        private int ano { get; set; }

        private Boolean excluido {get; set;}
//metodos
        public serie(int id, genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.excluido = false;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.genero + Environment.NewLine;
            retorno += "Título: " + this.titulo + Environment.NewLine;
            retorno += "Descrição: " + this.descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.ano + Environment.NewLine;
            retorno += "Excluido: " + this.excluido; 
            
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.titulo;
        }

        public int retornaId()
        {
            return this.id;
        }

        public Boolean retornaExcluido()
        {
            return this.excluido;
        }


        public void excluir()
        {
            this.excluido = true;
        }

    }
}