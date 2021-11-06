namespace EntityWPF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vedomost")]
    public partial class vedomost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_vedomost { get; set; }

        public int id_category { get; set; }

        [Required]
        [StringLength(120)]
        public string description { get; set; }

        public int count { get; set; }

        public decimal cena { get; set; }

        public DateTime? date { get; set; }

        public virtual category category { get; set; }
    }
}
