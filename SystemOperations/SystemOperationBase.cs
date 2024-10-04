using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IRepository repository = new GenericDbRepository();
        public void ExecuteTemplate(IDomainObject domainObject)
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                Execute(domainObject);
                repository.Commit();

            }
            catch (Exception )
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }
        protected abstract void Execute(IDomainObject domainObject);
    }
}
