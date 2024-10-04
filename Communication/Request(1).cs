using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public enum Operation
    {
        Login,
        End,
        IzmeniKlijenta,
        ObrisiKlijenta,
        ObrisiTermin,
        ObrisiUslugu,
        PretraziKlijente,
        PretraziTermine,
        PretraziUsluge,
        UcitajKlijenta,
        UcitajTermin,
        UcitajUslugu,
        VratiListuKlijenata,
        VratiListuTermina,
        VratiListuTipovaKlijenata,
        VratiListuTipovaNapomenaZaUslugu,
        VratiListuUsluga,
        VratiListuVrstaUsluga,
        ZapamtiKlijenta,
        ZapamtiTermine,
        ZapamtiUslugu,
        Logout,
        ProveriUlogovan,
        
    }
    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }
        public object RequestObject { get; set; } = null;
    }
}
