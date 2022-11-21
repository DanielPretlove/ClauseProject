using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Clause Text")]    
    public class ClauseText
    {
        [Key]
        public int ClauseId { get; set; }
        public string ClauseName { get; set; }
        public string Text { get; set; }
    }
}