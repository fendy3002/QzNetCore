using System;
using StackExchange.Redis;

namespace QzNetCore.Cache
{
    public class RedisCache<T> where T: class
    {
        public RedisCache(QzNetCore.Cache.Interface.ICacheService<T> service = null){
            this.service = service;
        }
        QzNetCore.Cache.Interface.ICacheService<T> service;

        public T get(QzNetCore.Cache.Interface.ICacheService<T> service = null){
            QzNetCore.Cache.Interface.ICacheService<T> usedService = service ?? this.service;

            return usedService.get();
        }
    }
}
