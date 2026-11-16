using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppEFcore02.Classes
{



   [Table("EventOrganizers")]        
    public class Organizer
    {


        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength (150)]
        public string? CompnayName {  get; set; }


        public bool IsVerfied {  get; set; }





    }
}
