using Common.Backend.Data.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Backend.Data.Entity
{
    /// <summary>
    /// ProductLog entity class
    /// </summary>
    [Table("ProductLog")]
    public record ProductLogEntity : BaseEntity, IAuditable
    {
        public int ProductId { get; set; }
        public double Amount { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
