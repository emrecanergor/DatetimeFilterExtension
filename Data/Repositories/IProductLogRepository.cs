using Common.Backend.Domain.ProductLog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Backend.Data.Repositories
{
    /// <summary>
    /// ProductLog repository interface
    /// </summary>
    public interface IProductLogRepository
    {
        /// <summary>
        /// Get all active ProductLog by filters
        /// </summary>
        /// <param name="startDate">start date Filter </param>
        /// <param name="endDate">end date Filter</param>
        /// <returns>ProductLogs list model</returns>
        Task<IEnumerable<ListProductLogResponseModel>> ListBetweenTwoDatesAsync(DateTime startDate, DateTime endDate);
    }
}
