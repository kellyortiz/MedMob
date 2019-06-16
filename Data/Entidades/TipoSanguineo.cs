using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Entidades
{
    [Table("TipoSanguineo")]
    public class TipoSanguineo
    {
        [Key]
        [Required]
        public int TipoSanguineoId { get; set; }

        [Required]
        [Display(Name ="Tipo sanguíneo:")]
        public string NomeTipoSanguineo { get; set; }
    }
}
