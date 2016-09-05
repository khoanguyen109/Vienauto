using System;
using NHibernate;
using Vienauto.Service.Dto;
using Vienauto.Service.Result;
using Vienauto.Entity.Entities;
using System.Collections.Generic;

namespace Vienauto.Service.Application
{
    public interface IManufacturerService
    {
        ServiceResult<IList<Manufacturer>> GetAllManufacturer();
    }

    public class ManufacturerService : BaseService, IManufacturerService
    {
        public ServiceResult<IList<Manufacturer>> GetAllManufacturer()
        {
            var result = new ServiceResult<IList<Manufacturer>>();
            try
            {
                var manufacturers = ListAll<Manufacturer>();
                result.Target = manufacturers;
            }
            catch(Exception ex)
            {
                result.AddError(ErrorCode.FailToListAll, ex);
            }
            return result;
        }
    }
}
