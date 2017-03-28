using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Red_wolf_project.Models
{
    public class Note
    {
        [Required]
        public int NoteId { get; set; }

        [Required]
        public string Title { get; set; }

        public string NoteBody { get; set; }

        [Required]
        public DateTime CreatedTimeStamp { get; set; }

        public DateTime EditTimeStamp { get; set; }
    }
}