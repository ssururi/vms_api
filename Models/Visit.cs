using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VMSApi.Models;

[Table("Visit")]
public partial class Visit
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string GuestId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CheckInDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckOutDate { get; set; }

    [Required]
    [StringLength(500)]
    [Unicode(false)]
    public string Purpose { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string VehicleType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string VehicleNo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string MeetWho { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Room { get; set; }

    [Required]
    [Column("SecurityPIC")]
    [StringLength(255)]
    [Unicode(false)]
    public string SecurityPic { get; set; }

    [Required]
    [Column("VMSNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Vmsno { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }
}
