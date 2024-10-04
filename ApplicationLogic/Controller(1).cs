using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace ApplicationLogic
{
    public class Controller
    {

        #region Singleton
        private static Controller instance;
        private Controller()
        {
        }
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }
        #endregion

        public void IzmeniKlijenta(Klijent klijent)
        {
            IzmeniKlijentaSO so = new IzmeniKlijentaSO();
            so.ExecuteTemplate(klijent);
        }
        public void ObrisiKlijenta(Klijent klijent)
        {
            ObrisiKlijentaSO so = new ObrisiKlijentaSO();
            so.ExecuteTemplate(klijent);
        }
        public void ObrisiTermin(Termin termin)
        {
            ObrisiTerminSO so = new ObrisiTerminSO();
            so.ExecuteTemplate(termin);
        }
        public void ObrisiUslugu(Usluga usluga)
        {
            ObrisiUsluguSO so = new ObrisiUsluguSO();
            so.ExecuteTemplate(usluga);
        }
        public List<Klijent> PretraziKlijente(Klijent kriterijum)
        {
            PretraziKlijenteSO so = new PretraziKlijenteSO();
            so.ExecuteTemplate(kriterijum);
            return so.Result;
        }
        public List<Termin> PretraziTermine(Termin kriterijum)
        {
            PretraziTermineSO so = new PretraziTermineSO();
            so.ExecuteTemplate(kriterijum);
            return so.Result;
        }
        public List<Usluga> PretraziUsluge(Usluga kriterijum)
        {
            PretraziUslugeSO so = new PretraziUslugeSO();
            so.ExecuteTemplate(kriterijum);
            return so.Result;
        }
        public Korisnik PrijaviAdministratora(Korisnik korisnik)
        {
            PrijaviAdministratoraSO so = new PrijaviAdministratoraSO();
            so.ExecuteTemplate(korisnik);
            return so.Result;
        }
        public Klijent UcitajKlijenta(Klijent klijent)
        {
            UcitajKlijentaSO so = new UcitajKlijentaSO();
            so.ExecuteTemplate(klijent);
            return so.Result;
        }
        public Termin UcitajTermin(Termin termin)
        {
            UcitajTerminSO so = new UcitajTerminSO();
            so.ExecuteTemplate(termin);
            return so.Result;
        }
        public Usluga UcitajUslugu(Usluga usluga)
        {
            UcitajUsluguSO so = new UcitajUsluguSO();
            so.ExecuteTemplate(usluga);
            return so.Result;
        }
        public List<Klijent> VratiListuKlijenata()
        {
            VratiListuKlijenataSO so = new VratiListuKlijenataSO();
            so.ExecuteTemplate(new Klijent());
            return so.Result;
        }
        public List<Termin> VratiListuTermina()
        {
            VratiListuTerminaSO so = new VratiListuTerminaSO();
            so.ExecuteTemplate(new Termin());
            return so.Result;
        }
        public List<TipKlijenta> VratiListuTipovaKlijenata()
        {
            VratiListuTipovaKlijenataSO so = new VratiListuTipovaKlijenataSO();
            so.ExecuteTemplate(new TipKlijenta());
            return so.Result;
        }
        public List<TipNapomeneZaUslugu> VratiListuTipovaNapomenaZaUslugu()
        {
            VratiListuTipovaNapomenaZaUsluguSO so = new VratiListuTipovaNapomenaZaUsluguSO();
            so.ExecuteTemplate(new TipNapomeneZaUslugu());
            return so.Result;
        }
        public List<Usluga> VratiListuUsluga()
        {
            VratiListuUslugaSO so = new VratiListuUslugaSO();
            so.ExecuteTemplate(new Usluga());
            return so.Result;
        }
        public List<VrstaUsluge> VratiListuVrstaUsluga()
        {
            VratiListuVrstaUslugaSO so = new VratiListuVrstaUslugaSO();
            so.ExecuteTemplate(new VrstaUsluge());
            return so.Result;
        }
        public Klijent ZapamtiKlijenta(Klijent klijent)
        {
            ZapamtiKlijentaSO so = new ZapamtiKlijentaSO();
            so.ExecuteTemplate(klijent);
            return so.Result;
        }
        public List<Termin> ZapamtiTermine(List<Termin> termini)
        {
            ZapamtiTerminеSO so = new ZapamtiTerminеSO
            {
                Termini = termini
            };
            so.ExecuteTemplate(new Termin());
            return so.Result;
        }
        public Usluga ZapamtiUslugu(Usluga usluga)
        {
            ZapamtiUsluguSO so = new ZapamtiUsluguSO();
            so.ExecuteTemplate(usluga);
            return so.Result;
        }
    }
}

