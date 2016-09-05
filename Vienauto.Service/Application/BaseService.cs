using System;
using NHibernate;
using Vienauto.Core.Nhibernate.Base;
using Vienauto.Core.Nhibernate.Context;

namespace Vienauto.Service.Application
{
    public class BaseService : Repository
    {
        protected override ISession Session { get; set; }

        protected override ISession OpenDefaultSession()
        {
            var sessionFactory = NhibernateConfiguration.GetDefaultSessionFactory();
            return sessionFactory.OpenSession();
        }

        protected override ISession OpenSession(string factoryKey = "")
        {
            var sessionFactory = NhibernateConfiguration.GetSessionFactory(factoryKey);
            return sessionFactory.OpenSession();
        }
    }
}
