using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMSApi.Dtos
{
    public class GuestWriteDto
    {
        [Required]
        public string Name { get; set; }

        public string Company { get; set; }

        [Required]
        public string IdCard { get; set; }

        [Required]
        public string IdCardNo { get; set; }

        public string Address { get; set; }
        
        public string Telepon { get; set; }
    }
}