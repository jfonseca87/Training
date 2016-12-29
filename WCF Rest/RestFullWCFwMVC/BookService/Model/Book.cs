using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace BookService.Model
{
    [Table("Book")]
    [DataContract]
    public class Book
    {
        [DataMember]
        [Key]
        public int BookId { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string ISBN { get; set; }
    }
}