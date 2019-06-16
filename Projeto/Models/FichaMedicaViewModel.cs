using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{

    //dados exibidos na view Detail
    public class FichaMedicaViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "RG:")]
        public string Rg { get; set; }

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

        [Display(Name = "Tipo sanguíneo:")]
        public string TipoSanguineo { get; set; }

        [Required]
        [Display(Name = "Data de nascimento:")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }

        [Required]
        [Display(Name = "Número:")]
        public int Numero { get; set; }

        [Required]
        [Display(Name = "Cidade:")]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "UF:")]
        public string UF { get; set; }

        [Required]
        [Display(Name = "País:")]
        public string Pais { get; set; }

        [Required]
        [Display(Name = "Telefone:")]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "Nome do Pai:")]
        public string NomePai { get; set; }

        [Required]
        [Display(Name = "Nome da Mãe:")]
        public string NomeMae { get; set; }


        // coleção de alergias da entidade Alergia para o Id do paciente em questão
        public ICollection<Alergia> Alergias { get; set; }
    }
}
