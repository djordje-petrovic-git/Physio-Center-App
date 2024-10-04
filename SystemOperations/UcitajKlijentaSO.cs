using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemOperations
{
    public class UcitajKlijentaSO : SystemOperationBase
    {
        public Klijent Result { get; private set; }
        protected override void Execute(IDomainObject domainObject)
        {
            Result = repository.GetSpecific(domainObject).Cast<Klijent>().ToList()[0];
        }
    }
}
