using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaosApp.Interfaces
{
    public interface IHttpClientService
    {
        Task<T?> PostAsync<T>(string url, object data);
        Task<T?> GetAsync<T>(string url);
        Task<T?> PutAsync<T>(string url, object data);
        Task<T?> DeleteAsync<T>(string url);
    }
}
