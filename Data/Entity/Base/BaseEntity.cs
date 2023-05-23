using Common.Backend.Data.Entity.Types;
using Common.Backend.Domain;

namespace Common.Backend.Data.Entity.Base
{
    /// <summary>
    /// Base entity class
    /// </summary>
    public abstract record BaseEntity
    {
        public int Id { get; set; }
        public StatusType Status { get; set; }
    }
}
