using Common.Backend.Core;
using Common.Backend.Core.Extensions;
using Common.Backend.Data.EF;
using Common.Backend.Data.Entity;
using Common.Backend.Data.Entity.Types;
using Common.Backend.Data.Extensions;
using Common.Backend.Data.Repositories;
using Common.Backend.Domain.ProductLog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Backend.Data.EFCore.ProductLog
{
    /// <summary>
    /// ProductLog repository class
    /// </summary>
    public class ProductLogRepository : IProductLogRepository
    {
        #region "VARIABLES"

        private readonly DataContext _dataContext;
        private readonly IWorkContext _workContext;

        #endregion

        #region "CTOR"

        public ProductLogRepository(DataContext dataContext, IWorkContext workContext)
        {
            _dataContext = dataContext;
            _workContext = workContext;
        }

        #endregion

        #region "METHODS"

        public async Task<IEnumerable<ListProductLogResponseModel>> ListBetweenTwoDatesAsync(DateTime startDate, DateTime endDate)
        {
            var result = await _dataContext.ProductLogs.FilterWithTwoDates(startDate, endDate);

            return result.ToModel<IEnumerable<ListProductLogResponseModel>>();
        }
        
        #endregion
    }
}
