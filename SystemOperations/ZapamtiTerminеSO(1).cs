using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemOperations
{
    public class ZapamtiTerminеSO : SystemOperationBase
    {
        public List<Termin> Result { get; private set; }
        public List<Termin> Termini { get; set; }
        protected override void Execute(IDomainObject domainObject)
        {
            foreach (Termin t in Termini)
            {
                repository.Save(t);
            }
            Result = Termini;
        }
    }
}
