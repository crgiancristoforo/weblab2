namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MenuItem
    {
        public int Id { get; set; }

        public int IdMenu { get; set; }

        [Required]
        [StringLength(20)]
        public string MenuItem { get; set; }

        [Required]
        [StringLength(20)]
        public string Rota { get; set; }

        public DateTime DataHora { get; set; }

        public virtual TB_Menu TB_Menu { get; set; }
    }
}
