using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverflow.Models
{
    [Table("Answers")]
    public class Answer
    {
        [Key]
        public int AId { get; set; }
        public string ABody { get; set; }

        public int AVotes { get; set; }

        public virtual Question Question { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
