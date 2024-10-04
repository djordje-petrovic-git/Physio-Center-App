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
    public class Usluga : IDomainObject
    {
        [Browsable(false)]
        public int SifraUsluge { get; set; }
        public string NazivUsluge { get; set; }
        public double CenaUsluge { get; set; }
        public int TrajanjeUsluge { get; set; }
        public VrstaUsluge SifraVrsteUsluge { get; set; }

        [Browsable(false)]
        public List<NapomenaZaUslugu> NapomeneZaUslugu { get; set; }

        [Browsable(false)]
        public string TableName => "Usluga";
        [Browsable(false)]
        public string TableAlias => "u";
        [Browsable(false)]
        public string JoinTable => "join VrstaUsluge vu";
        [Browsable(false)]
        public string JoinCondition => "on (u.SifraVrsteUsluge=vu.SifraVrsteUsluge)";
        [Browsable(false)]
        public string WhereCondition => $"SifraUsluge={SifraUsluge}";
        [Browsable(false)]
        public string GeneralCondition => $"u.SifraUsluge={SifraUsluge}";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string InsertValues => $"'{NazivUsluge}', {CenaUsluge}, {TrajanjeUsluge}, {SifraVrsteUsluge.SifraVrsteUsluge}";
        [Browsable(false)]
        public string OutputInserted => "";
        [Browsable(false)]
        public string SearchCondition { get => searchCondition; set => searchCondition = value; }

        private string searchCondition;

        public override string ToString()
        {
            return NazivUsluge;
        }

        public List<IDomainObject> GetObjects(SqlDataReader reader)
        {
            List<IDomainObject> result = new List<IDomainObject>();

            while (reader.Read())
            {
                result.Add(new Usluga
                {
                    SifraUsluge = (int)reader["SifraUsluge"],
                    NazivUsluge = (string)reader["NazivUsluge"],
                    CenaUsluge = (double)reader["CenaUsluge"],
                    TrajanjeUsluge = (int)reader["TrajanjeUsluge"],
                    SifraVrsteUsluge = new VrstaUsluge
                    {
                        SifraVrsteUsluge = (int)reader["SifraVrsteUsluge"],
                        NazivVrsteUsluge = (string)reader["NazivVrsteUsluge"]
                    }
                });
            }
            return result;
        }
    }
}
