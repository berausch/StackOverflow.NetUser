using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverflow.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QId { get; set; }
        public string Title { get; set; }
        public string QBody { get; set; }

        public int QVotes { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
