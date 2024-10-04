using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemOperations
{
    public class ZapamtiKlijentaSO : SystemOperationBase
    {
        public Klijent Result { get; private set; }
        public Klijent Klijent { get; set; }
        protected override void Execute(IDomainObject domainObject)
        {
            repository.Save(domainObject);
            Result = (Klijent)domainObject;
        }
    }
}
