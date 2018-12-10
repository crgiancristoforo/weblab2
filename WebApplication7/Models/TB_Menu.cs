namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Menu()
        {
            TB_MenuItem = new HashSet<TB_MenuItem>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Menu { get; set; }

        public DateTime DataHora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_MenuItem> TB_MenuItem { get; set; }
    }
}
