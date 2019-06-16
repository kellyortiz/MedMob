using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Entidades
{
    [Table("Paciente")]
    public class Paciente
    {
        [Required]
        [Key]
        [Display(Name ="RG:")]
        public int Rg { get; set; }

        [Required]
        [Display(Name = "Nome completo:")]
        public string NomeCompleto { get; set; }

        [Required]
        [Display(Name = "Empresa do convênio:")]
        public string NomeConvenio { get; set; }

        [Required]
        [Display(Name = "Número da carteira de convênio:")]
        public string NumeroConvenio { get; set; }

        [Required]
        [Display(Name = "Doença crônica:")]
        public string DoencaCronica { get; set; }

        [ForeignKey("TipoSanguineo")]
        [Display(Name = "Tipo sanguíneo:")]
        public int TipoSanguineoId { get; set; }
        public TipoSanguineo TipoSanguineo { get; set; }

        [Required]
        [Display(Name ="Data de nascimento:")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Display(Name ="Endereço:")]
        public string NomeEndereco { get; set; }

        [Required]
        [Display(Name ="Número:")]
        public int NumeroEndereco { get; set; }

        [Required]
        [Display(Name ="Cidade:")]
        public string NomeCidade { get; set; }

        [Required]
        [Display(Name = "UF:")]
        public string NomeUF { get; set; }

        [Required]
        [Display(Name = "País:")]
        public string NomePais { get; set; }

        [Required]
        [Display(Name = "Telefone:")]
        public string NumeroTelefone { get; set; }

        [Required]
        [Display(Name = "Nome do Pai:")]
        public string NomePai { get; set; }

        [Required]
        [Display(Name = "Nome da Mãe:")]
        public string NomeMae { get; set; }
    }
}
