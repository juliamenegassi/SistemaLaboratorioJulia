using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LaboratorioExame.Models
{
    [Table("Cargo")]
    public class Cargo
    {
        [Column("CargoId")]
        [Display(Name = "Id do Cargo")]
        public int CargoId { get; set; }

        [Column("CargoNome")]
        [Display(Name = "Nome do Cargo")]
        public string CargoNome { get; set; } = string.Empty;
    }
}
