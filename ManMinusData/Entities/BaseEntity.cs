using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManMinusData.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public DateTime CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        protected BaseEntity()
        {
            CreatedOnUtc = DateTime.UtcNow;
        }
    }
}
