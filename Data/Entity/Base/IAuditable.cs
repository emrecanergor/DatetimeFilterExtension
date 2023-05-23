using System;

namespace Common.Backend.Data.Entity.Base
{
    /// <summary>
    /// Auditable interface
    /// </summary>
    public interface IAuditable
    {
        DateTime CreatedOn { get; set; }
        int CreatedBy { get; set; }
        DateTime? ModifiedOn { get; set; }
        int? ModifiedBy { get; set; }
    }
}
