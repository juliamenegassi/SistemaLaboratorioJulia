using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratorioExame.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Column("PacienteId")]
        [Display(Name = "Id do Paciente")]
    }
}
