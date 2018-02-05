using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NH01
{
    class Program
    {
        static void Main(string[] args)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
                //var lst = session.CreateQuery("from Member").List<Member>();
                var lst = session.QueryOver<Member>().List();
                foreach (var item in lst)
                {
                    Console.WriteLine(item.Mobile);
                }
            }
            Console.ReadKey();
        }
    }
}
