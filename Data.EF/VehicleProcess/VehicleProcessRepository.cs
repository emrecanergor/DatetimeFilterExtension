using Common.Backend.Core;
using Common.Backend.Core.Extensions;
using Common.Backend.Data.EF;
using Common.Backend.Data.Entity;
using Common.Backend.Data.Entity.Types;
using Common.Backend.Data.Extensions;
using Common.Backend.Data.Repositories;
using Common.Backend.Domain.VehicleProcess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Backend.Data.EFCore.VehicleProcess
{
    /// <summary>
    /// VehicleProcess repository class
    /// </summary>
    public class VehicleProcessRepository : IVehicleProcessRepository
    {
        #region "VARIABLES"

        private readonly DataContext _dataContext;
        private readonly IWorkContext _workContext;

        #endregion

        #region "CTOR"

        public VehicleProcessRepository(DataContext dataContext, IWorkContext workContext)
        {
            _dataContext = dataContext;
            _workContext = workContext;
        }

        #endregion

        #region "METHODS"

        public async Task<IEnumerable<ListVehicleProcessResponseModel>> ListBetweenTwoDatesAsync(DateTime startDate, DateTime endDate)
        {
            var result = await _dataContext.VehicleProcesses.FilterWithTwoDates(startDate, endDate);

            return result.ToModel<IEnumerable<ListVehicleProcessResponseModel>>();
        }

        #endregion
    }
}
