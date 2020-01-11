using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Municipality
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^\\d{4}$")]
        public string ZipCode { get; set; }
        public virtual IEnumerable<School> Schools { get; set; }
    }
}
