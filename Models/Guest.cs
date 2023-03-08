using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VMSApi.Models;

[Table("Guest")]
public partial class Guest
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Company { get; set; }

    [Required]
    [StringLength(10)]
    [Unicode(false)]
    public string IdCard { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string IdCardNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Telepon { get; set; }
}
