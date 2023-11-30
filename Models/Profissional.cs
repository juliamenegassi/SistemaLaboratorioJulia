    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LaboratorioExame.Models
{
    [Table("Profissional")]
    public class Profissional
    {
        [Column("profissionalId")]
        [Display(Name = "Id do Profissional")]
        public int ProfissionalId { get; set; }

        [Column("profissionalNome")]
        [Display(Name = "Nome do Profissional")]
        public string ProfissionaNome { get; set; } = string.Empty;

        [ForeignKey("CargoId")]
        public int CargoId { get; set; }

        public Cargo? Cargo { get; set; }

    }
}