using Common.Backend.Domain.VehicleProcess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Backend.Data.Repositories
{
    /// <summary>
    /// VehicleProcess repository interface
    /// </summary>
    public interface IVehicleProcessRepository
    {
        /// <summary>
        /// Get all active VehicleProcess by filters
        /// </summary>
        /// <param name="startDate">start date Filter </param>
        /// <param name="endDate">end date Filter</param>
        /// <returns>VehicleProcesss list model</returns>
        Task<IEnumerable<ListVehicleProcessResponseModel>> ListBetweenTwoDatesAsync(DateTime startDate, DateTime endDate);
    }
}
