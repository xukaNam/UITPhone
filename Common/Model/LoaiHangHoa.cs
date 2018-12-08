using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

public class LoaiHangHoa

{
    [Key]
    public int MaLoaiHangHoa { get; set; }

    [StringLength(50)]
    public string TenLoaiHangHoa { get; set; }

    public int PhanTramLoiNhuan { get; set; }
}
