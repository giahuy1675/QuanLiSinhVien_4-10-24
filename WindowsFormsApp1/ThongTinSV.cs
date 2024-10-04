namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinSV")]
    public partial class ThongTinSV
    {
        [Key]
        [StringLength(50)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        public double Diem { get; set; }

        public int MaKhoa { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
