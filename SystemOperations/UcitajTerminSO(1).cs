using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajTerminSO : SystemOperationBase
    {
        public Termin Result { get; private set; }
        protected override void Execute(IDomainObject domainObject)
        {
            Result = repository.GetSpecific(domainObject).Cast<Termin>().ToList()[0];
        }
    }
}
