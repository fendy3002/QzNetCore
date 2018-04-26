using System;
using StackExchange.Redis;

namespace QzNetCore.Cache.Interface
{
    public interface ICacheService<T> where T:class
    {
        T get(T latest = null);
    }
}
