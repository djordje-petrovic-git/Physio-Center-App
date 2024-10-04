using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class PrijaviAdministratoraSO : SystemOperationBase
    {
        public Korisnik Result { get; private set; }
        protected override void Execute(IDomainObject domainObject)
        {
            Korisnik k = (Korisnik)domainObject;
            Result = repository.GetAll(domainObject).Cast<Korisnik>().ToList().
                FirstOrDefault(x => x.KorisnickoIme == k.KorisnickoIme && x.Lozinka == k.Lozinka);
        }
    }
}
