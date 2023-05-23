using Common.Backend.Data.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Backend.Data.Entity
{
    /// <summary>
    /// VehicleProcess entity class
    /// </summary>
    [Table("VehicleProcess")]
    public record VehicleProcessEntity : BaseEntity, IAuditable
    {
        public int VehicleId { get; set; }
        public double TransporterCommision { get; set; }
        public double NetWeight { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
