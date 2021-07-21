using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ButtonProject.Models
{
    public class ButtonInfo
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string State { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Country { get; set; }


    }
}
