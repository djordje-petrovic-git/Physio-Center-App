using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class PretraziKlijenteSO : SystemOperationBase
    {
        public List<Klijent> Result { get; private set; }
        protected override void Execute(IDomainObject domainObject)
        {
            Result = repository.GetAllWithCondition(domainObject).Cast<Klijent>().ToList();
        }
    }
}
