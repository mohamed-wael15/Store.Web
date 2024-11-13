using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.service.services.CacheServices
{
    public interface ICacheService
    {
        Task SetCacheResponseAsync(string Key, object response, TimeSpan timeToLive);
        Task<string> GetCacheResponseAsync(string key);
    }
}
