namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Cliente
    {
        [Key]
        public int ID_Cliente { get; set; }

        [Required]
        [StringLength(100)]
        public string DS_Nome { get; set; }

        public DateTime DT_Inclusao { get; set; }
    }
}
