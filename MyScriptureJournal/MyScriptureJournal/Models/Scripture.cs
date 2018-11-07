using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [Display(Name = "Book")]
        public String Book { get; set; }

        [Display(Name = "Verse")]
        public String Verse { get; set; }

        [Display(Name = "Notes")]
        public String Notes { get; set; }

        [Display(Name = "Added Date")]
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }
    }
}
