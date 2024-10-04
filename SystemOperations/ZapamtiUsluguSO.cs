using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemOperations
{
    public class ZapamtiUsluguSO : SystemOperationBase
    {
        public Usluga Result { get; private set; }
        public Usluga Usluga { get; set; }
        protected override void Execute(IDomainObject domainObject)
        {
            repository.Save(domainObject);
            Usluga u = (Usluga)domainObject;

            var usluge = repository.GetAll(domainObject).Cast<Usluga>().ToList();
            int id = usluge.Max(x => x.SifraUsluge);

            foreach (NapomenaZaUslugu n in u.NapomeneZaUslugu)
            {
                n.SifraUsluge.SifraUsluge = id;
                repository.Save(n);
            }
            Result = (Usluga)domainObject;
        }
    }
}
