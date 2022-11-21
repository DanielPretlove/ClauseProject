using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Clause Left")]
    public class ClauseLeft
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Clause { get; set; }
    }
}