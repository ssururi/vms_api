using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMSApi.Dtos
{
    public class GuestReadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string IdCard { get; set; }
        public string IdCardNo { get; set; }
        public string Address { get; set; }
        public string Telepon { get; set; }
    }
}