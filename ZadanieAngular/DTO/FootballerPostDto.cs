using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZadanieAngular.DTO
{
    public class FootballerPostDto
    {
        public Guid FootballerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImgPath { get; set; }
    }
}
