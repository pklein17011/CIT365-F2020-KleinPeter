using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace My_Scripture_Journal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        [Display(Name = "Note Title")]
        public string NoteTitle { get; set; }

        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }

        public string GetScriptureAddress()
        {
            return $"{Book} {Chapter}:{Verse}";
        }

        public string Note { get; set; }
        public string Passage { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get;  set; }
        
        public Scripture()
        {
            DateAdded = DateTime.Now;
        }

    }
}
