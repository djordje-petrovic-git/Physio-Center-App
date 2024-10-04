using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemOperations
{
    public class UcitajUsluguSO : SystemOperationBase
    {
        public Usluga Result { get; private set; }
        protected override void Execute(IDomainObject domainObject)
        {
            Result = repository.GetSpecific(domainObject).Cast<Usluga>().ToList()[0];
            var napomene = repository.GetAll(new NapomenaZaUslugu()).Cast<NapomenaZaUslugu>().ToList();

            Result.NapomeneZaUslugu = napomene.Where(x => x.SifraUsluge.SifraUsluge == Result.SifraUsluge).ToList();
        }
    }
}
