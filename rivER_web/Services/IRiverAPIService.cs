using rivER_web.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rivER_web.Services
{
    public interface IRiverAPIService
    {
        Task<IEnumerable<T>> GetRiverModelsAsync<T>(string queryParameters = null)
            where T : BaseIdentifiable, new();
        Task<T> GetRiverModelByIdAsync<T>(string id, string queryParameters = null)
            where T : BaseIdentifiable, new();
        Task<T> PostRiverModelAsync<T>(T model)
            where T : BaseIdentifiable;
    }
}
