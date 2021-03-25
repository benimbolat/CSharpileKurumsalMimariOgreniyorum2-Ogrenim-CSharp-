using NHibernate; //hibernate 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHihabernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;
        public virtual ISessionFactory SessionFactory
        {
            get
            {
                return _sessionFactory ?? (_sessionFactory = Initializefactory());
            }
        }
        protected abstract ISessionFactory Initializefactory();
        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        public void Dispose()
        {
           GC.SuppressFinalize(this.);
        }
    }
}
