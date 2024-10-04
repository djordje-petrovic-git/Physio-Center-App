﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SystemOperations
{
    public class VratiListuTipovaKlijenataSO : SystemOperationBase
    {
        public List<TipKlijenta> Result { get; private set; }
        protected override void Execute(IDomainObject domainObject)
        {
            Result = repository.GetAll(domainObject).Cast<TipKlijenta>().ToList();
        }
    }
}
