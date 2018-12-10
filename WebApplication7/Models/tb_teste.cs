namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_teste
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string DS_Teste { get; set; }
    }
}
