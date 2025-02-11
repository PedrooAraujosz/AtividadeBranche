namespace AtividadeBranche.Controllers
{
    public class Livros
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        public Livros(string nome, string autor, string editora)
        {
            Nome = nome;
            Autor = autor;
            Editora = editora;
        }
    }
}
