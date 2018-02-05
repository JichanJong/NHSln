using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NH02
{
    class Program
    {
        static void Main(string[] args)
        {

            var configure = new Configuration()
                    .DataBaseIntegration(dbi =>
                    {
                        dbi.Dialect<MsSql2008Dialect>();
                        dbi.Driver<SqlClientDriver>();
                        dbi.ConnectionProvider<DriverConnectionProvider>();
                        dbi.ConnectionStringName = "SqlServer";
                    });

            //configure .AddAssembly("NHibernateDemo") ;
            ModelMapper mapper = new ModelMapper();
            mapper.AddMapping<MemberMap>();
            HbmMapping mapping = mapper.CompileMappingFor(new[] { typeof(Member) });
            configure.AddDeserializedMapping(mapping, null);

            ISessionFactory factory = configure.BuildSessionFactory();
            ISession session = factory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())
            {
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
