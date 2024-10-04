using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Klijent : IDomainObject
    {
        [Browsable(false)]
        public int SifraKlijenta { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Starost { get; set; }
        [Browsable(false)]
        public string BrojTelefona { get; set; }
        [Browsable(false)]
        public string Email { get; set; }
        [Browsable(false)]
        public TipKlijenta SifraTipaKlijenta { get; set; }
        [Browsable(false)]
        public string TableName => "Klijent";
        [Browsable(false)]

        public string TableAlias => "kl";
        [Browsable(false)]

        public string JoinTable => "join TipKlijenta tk";
        [Browsable(false)]

        public string JoinCondition => "on (kl.SifraTipaKlijenta=tk.SifraTipaKlijenta)";
        [Browsable(false)]

        public string WhereCondition => $"SifraKlijenta={SifraKlijenta}";
        [Browsable(false)]

        public string GeneralCondition => $"kl.SifraKlijenta={SifraKlijenta}";
        [Browsable(false)]

        public object SelectValues => "*";
        [Browsable(false)]

        public string UpdateValues => $"Ime='{Ime}', Prezime='{Prezime}', Starost={Starost}, BrojTelefona='{BrojTelefona}', " +
            $"Email='{Email}', SifraTipaKlijenta={SifraTipaKlijenta.SifraTipaKlijenta}";
        [Browsable(false)]

        public string InsertValues => $"'{Ime}', '{Prezime}', {Starost}, '{BrojTelefona}', '{Email}', " +
            $"{SifraTipaKlijenta.SifraTipaKlijenta}";
        [Browsable(false)]

        public string OutputInserted => "";
        [Browsable(false)]

        public string SearchCondition { get => searchCondition; set => searchCondition = value; }

        private string searchCondition;

        [Browsable(false)]
        public List<IDomainObject> GetObjects(SqlDataReader reader)
        {
            List<IDomainObject> result = new List<IDomainObject>();

            while (reader.Read())
            {
                result.Add(new Klijent
                {
                    SifraKlijenta = (int)reader["SifraKlijenta"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    Starost = (int)reader["Starost"],
                    BrojTelefona = (string)reader["BrojTelefona"],
                    Email = (string)reader["Email"],
                    SifraTipaKlijenta = new TipKlijenta
                    {
                        SifraTipaKlijenta = (int)reader["SifraTipaKlijenta"],
                        NazivTipaKlijenta = (string)reader["NazivTipaKlijenta"]
                    }
                });
            }
            return result;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime + ", " + Email;
        }
        public override bool Equals(object obj)
        {
            if (obj is Klijent)
            {
                return ((Klijent)obj).SifraKlijenta == SifraKlijenta;
            }
            return false;
        }
    }

   
}
