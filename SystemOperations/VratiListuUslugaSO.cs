using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemOperations
{
    public class VratiListuUslugaSO : SystemOperationBase
    {
        public List<Usluga> Result { get; private set; }
        protected override void Execute(IDomainObject domainObject)
        {
            Result = repository.GetAll(domainObject).Cast<Usluga>().ToList();
            var napomene = repository.GetAll(new NapomenaZaUslugu()).Cast<NapomenaZaUslugu>().ToList();

            foreach (Usluga u in Result)
            {
                u.NapomeneZaUslugu = napomene.Where(x => x.SifraUsluge.SifraUsluge == u.SifraUsluge).ToList();
            }
        }
    }
}
