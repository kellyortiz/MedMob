using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Entidades
{
    // cria modela da tabela Paciente
    [Table("Paciente")]
    public class Paciente
    {
        public Paciente()
        {
            Alergias = new HashSet<Alergia>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Rg { get; set; }

        [Required]
        public string NomeCompleto { get; set; }

        [Required]
        public string NomeConvenio { get; set; }

        [Required]
        public string NumeroConvenio { get; set; }

        [Required]
        public string DoencaCronica { get; set; }

        [Required]
        public string TipoSanguineo { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string UF { get; set; }

        [Required]
        public string Pais { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string NomePai { get; set; }

        [Required]
        public string NomeMae { get; set; }

        public ICollection<Alergia> Alergias { get; set; }
    }
}