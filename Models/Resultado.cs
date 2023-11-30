using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LaboratorioExame.Models
{
    [Table("Resultado")]
    public class Resultado
    {
        [Column("ResultadoId")]
        [Display(Name = "Id do resultado")]
        public int ResultadoId { get; set; }

        [ForeignKey("PacienteId")]
        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }

        [ForeignKey("ExameId")]
        public int ExameId { get; set; }
        public Exame? Exame { get; set; }

        [Column("ResultadoDescricao")]
        [Display(Name = "Resultado do Exame")]
        public string ResultadoDescricao { get; set; } = string.Empty;

        [Column("DataRealizacao")]
        [Display(Name = "Data da Realizacao")]
        public DateTime DataRealizacao { get; set; }

        [ForeignKey("ProfissionalId")]
        public int ProfissionalId { get; set; }
        public Profissional? Proissional { get; set; }

        [Column("ObservacaoResultado")]
        [Display(Name = "Observacao do Resultado")]
        public string ObservacaoResultado { get; set; } = string.Empty;
    }
}
