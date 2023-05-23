using Common.Backend.Data.Entity.Base;
using Common.Backend.Data.Entity.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Backend.Data.Extensions
{
    public static class GenericFilterExtension
    {
        public static async Task<List<T>> FilterWithTwoDates<T>(this DbSet<T> model, DateTime startDate, DateTime endDate) where T : BaseEntity, IAuditable
        {
            List<T> result = new();

            if (startDate > DateTime.MinValue && endDate > DateTime.MinValue) //fetch data between two dates
            {
                result = await model.AsNoTracking().Where(f => f.CreatedOn >= startDate && f.CreatedOn <= endDate && f.Status != StatusType.Deleted).ToListAsync();
            }
            else if (startDate > DateTime.MinValue) //fetch data after startDate
            {
                result = await model.AsNoTracking().Where(f => f.CreatedOn >= startDate && f.Status != StatusType.Deleted).ToListAsync();
            }
            else if (endDate > DateTime.MinValue) //fetch data before endDate
            {
                result = await model.AsNoTracking().Where(f => f.CreatedOn <= endDate && f.Status != StatusType.Deleted).ToListAsync();
            }
            else //fetch all data
            {
                result = await model.AsNoTracking().Where(f => f.Status != StatusType.Deleted).ToListAsync();
            }

            return result;
        }
    }
}
