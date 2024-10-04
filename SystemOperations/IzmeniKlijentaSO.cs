using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class IzmeniKlijentaSO : SystemOperationBase
    {

        protected override void Execute(IDomainObject domainObject)
        {
            repository.Update(domainObject);
        }
    }
}
