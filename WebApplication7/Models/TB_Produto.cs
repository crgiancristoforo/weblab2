namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Produto
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Nome { get; set; }
    }
}
