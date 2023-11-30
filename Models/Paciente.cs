using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LaboratorioExame.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Column("PacienteId")]
        [Display(Name = "Id do Paciente")]
        public int PacienteId { get; set; }

        [Column("PacienteNome")]
        [Display(Name = "Nome do Paciente")]
        public string PacienteNome { get; set; } = string.Empty;

        [Column("PacienteSexo")]
        [Display(Name = "Sexo")]
        public string Pacientesexo { get; set; } = string.Empty;

        [Column("PacienteCpf")]
        [Display(Name = "CPF")]
         public string PacienteCpf { get; set; } = string.Empty;

        [Column("Pacientetelefone")]
        [Display(Name = "Telefone")]
        public string PacienteTelefone { get; set; } = string.Empty;

        [Column("PacienteNomeMae")]
        [Display(Name = "Nome da mãe")]
        public string PacienteNomeMae { get; set; } = string.Empty;

        [Column("PacienteTipoSanguineo")]
        [Display(Name = "Tipo Sanguíneo")]
        public string PacienteTipoSanguineo { get; set; } = string.Empty;

        [Column("PacienteIdade")]
        [Display(Name = "Idade")]
        public string PacienteIdade { get; set; } = string.Empty;

        [Column("PacienteAlergia")]
        [Display(Name = "Alergia")]
        public string PacienteAlergia { get; set; } = string.Empty;

        [Column("PacienteEndereco")]
        [Display(Name = "Endereço")]
        public string PacienteEndereco { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [Column("PacientePeso")]
        [Display(Name = "Peso")]
        public double PacientePeso { get; set; }

        [Column("PacienteAltura")]
        [Display(Name = "Altura")]
        public double PacienteAltura { get; set; }

        [Column("PacienteObservacao")]
        [Display(Name = "Observação")]
        public string PacienteObservacao { get; set; } = string.Empty;
    }
    }

