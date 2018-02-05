using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;

namespace NH01
{
    public class CacheHelper
    {
        //ObjectCacheProvider

        private static readonly ObjectCache Cache = MemoryCache.Default;

        public static object Get(string key)
        {
            return Cache.Get(key);
        }

        public static void Set(string key, object value)
        {
            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromHours(1);
            Cache.Set(key, value, policy);
        }

        public static void Remove(string key)
        {
            Cache.Remove(key);
        }
    }
}
