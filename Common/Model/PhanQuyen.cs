using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

public partial class PhanQuyen
{
    [Key]
    [StringLength(100)]
    public int MaQuyen { get; set; }

    [StringLength(100)]
    public string TenQuyen { get; set; }


}
