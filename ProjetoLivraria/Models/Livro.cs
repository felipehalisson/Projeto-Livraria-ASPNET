using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLivraria.Models
{
    [Table("livro")]
    public class Livro
    {
        public int Id { get; set; }

        public string Isbn { get; set; }

        public string Nome { get; set; }

        public string? Descricao { get; set; }

        public decimal Valor { get; set; }
    }
}