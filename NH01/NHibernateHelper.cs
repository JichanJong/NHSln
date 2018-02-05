using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NH01
{
    public sealed class NHibernateHelper
    {
        private const string CurrentSessionKey = "nhibernate.current_session";
        private static readonly ISessionFactory _sessionFactory;
        static NHibernateHelper()
        {
            _sessionFactory = new Configuration().Configure().BuildSessionFactory();
        }
        public static ISession GetCurrentSession()
        {
            var currentSession = CacheHelper.Get("CurrentSessionKey") as ISession;
            if (currentSession == null)
            {
                currentSession = _sessionFactory.OpenSession();
                CacheHelper.Set("CurrentSessionKey", currentSession);
            }
            return currentSession;
        }
        public static void CloseSession()
        {
            var currentSession = CacheHelper.Get("CurrentSessionKey") as ISession;
            if (currentSession == null)
            {
                // No current session
                return;
            }
            currentSession.Close();
            CacheHelper.Remove("CurrentSessionKey");
        }
        public static void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }
    }
}
