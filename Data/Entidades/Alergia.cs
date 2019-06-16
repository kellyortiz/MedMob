using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Entidades
{
    [Table("Alergia")]
    public class Alergia
    {
        [Key]
        [Required]
        public int MedicamentoId { get; set; }

        [ForeignKey("Paciente")]
        public int PacienteId { get; set; }
        public Paciente Rg { get; set; }

        [Required]
        [Display(Name ="Nome medicamento:")]
        public string NomeMedicamento { get; set; }
    }
}
