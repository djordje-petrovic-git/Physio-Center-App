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
    public class Korisnik : IDomainObject
    {
        public int SifraKorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        public override bool Equals(object obj)
        {
            if (obj is Korisnik)
            {
                return ((Korisnik)obj).SifraKorisnika == SifraKorisnika;
            }
            return false;
        }
        [Browsable(false)]
        public string TableName => "Korisnik";
        [Browsable(false)]
        public string TableAlias => "k";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GeneralCondition => "";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string OutputInserted => "";
        [Browsable(false)]
        public string SearchCondition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IDomainObject> GetObjects(SqlDataReader reader)
        {
            List<IDomainObject> result = new List<IDomainObject>();

            while (reader.Read())
            {
                result.Add(new Korisnik
                {
                    SifraKorisnika = (int)reader["SifraKorisnika"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    KorisnickoIme = (string)reader["KorisnickoIme"],
                    Lozinka = (string)reader["Lozinka"]
                });
            }
            return result;
        }
    }
}
