using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Entidades
{
    // cria tabela alergia baseada na classe alergia
    [Table("Alergia")]
    public class Alergia
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int PacienteId { get; set; }

        [Required]
        public string NomeMedicamento { get; set; }

        [ForeignKey("PacienteId")]
        public Paciente Paciente { get; set; }
    }
}