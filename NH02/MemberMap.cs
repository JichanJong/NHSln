using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NH02
{
    public class MemberMap : ClassMapping<Member>
    {
        public MemberMap()
        {
            Table("Member");
            Id<int>(m => m.Id, map =>
            {
                map.Column("Id");
                map.Generator(Generators.Native);
            });
            Property<string>(m => m.Name);
            Property<string>(m => m.Password);
            Property<DateTime>(m => m.CreateTime);
            Property<bool>(m => m.Del);
            Property<string>(m => m.Mobile);
            Property<string>(m => m.Email);
            Property<string>(m => m.RealName);
            Property<string>(m => m.IDCard);
        }
    }
}
