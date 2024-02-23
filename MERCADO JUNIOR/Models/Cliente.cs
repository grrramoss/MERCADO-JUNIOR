using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MERCADO_JUNIOR.Models
{
    public class Cliente
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }


        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefone { get; set; }
    }
}