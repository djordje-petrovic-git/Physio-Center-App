using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository
    {
        // ne sme da sadrzi metode koje nisu genericke: npr. Login
        void Save(IDomainObject domainObject);
        void Update(IDomainObject domainObject);
        List<IDomainObject> GetAll(IDomainObject domainObject);
        List<IDomainObject> GetAllWithCondition(IDomainObject domainObject);
        List<IDomainObject> GetSpecific(IDomainObject domainObject);
        void Delete(IDomainObject domainObject);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
