using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Clause Right")]
    public class ClauseRight
    {
        [Key]
        public int ClauseId { get; set; }
        [Required]
        public string Clause { get; set; }

    }
}


