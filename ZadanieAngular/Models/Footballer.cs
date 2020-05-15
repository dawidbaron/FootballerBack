using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZadanieAngular.Models
{
    public class Footballer
    {
        [Key]
        public Guid FootballerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImgPath { get; set; }
    }
}
