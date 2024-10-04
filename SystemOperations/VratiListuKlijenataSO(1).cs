using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemOperations
{
    public class VratiListuKlijenataSO : SystemOperationBase
    {
        public List<Klijent> Result { get; private set; }
        protected override void Execute(IDomainObject domainObject)
        {
            Result = repository.GetAll(domainObject).Cast<Klijent>().ToList();
        }
    }
}
