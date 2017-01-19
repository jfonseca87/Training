using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoWepAPI_3.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage="The Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The ISBN is required")]
        public string ISBN { get; set; }
    }
}