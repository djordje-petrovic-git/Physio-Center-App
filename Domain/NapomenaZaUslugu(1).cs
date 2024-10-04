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
    public class NapomenaZaUslugu : IDomainObject
    {
        [Browsable(false)]
        public Usluga SifraUsluge { get; set; }
        [Browsable(false)]
        public int RedniBroj { get; set; }
        public string OpisNapomene { get; set; }
        public TipNapomeneZaUslugu SifraTipaNapomene { get; set; }

        [Browsable(false)]
        public string TableName => "NapomenaZaUslugu";
        [Browsable(false)]
        public string TableAlias => "nzu";
        [Browsable(false)]
        public string JoinTable => "join Usluga u";
        [Browsable(false)]
        public string JoinCondition => "on (nzu.SifraUsluge=u.SifraUsluge) join TipNapomeneZaUslugu tnzu on " +
            "(nzu.SifraTipaNapomene=tnzu.SifraTipaNapomene) join VrstaUsluge vu on " +
            "(u.SifraVrsteUsluge=vu.SifraVrsteUsluge)";
        [Browsable(false)]
        public string WhereCondition => $"RedniBroj={RedniBroj}";
        [Browsable(false)]
        public string GeneralCondition => "";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string InsertValues => $"{SifraUsluge.SifraUsluge}, {RedniBroj}, '{OpisNapomene}', {SifraTipaNapomene.SifraTipaNapomene}";
        [Browsable(false)]
        public string OutputInserted => "";
        [Browsable(false)]
        public string SearchCondition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IDomainObject> GetObjects(SqlDataReader reader)
        {
            List<IDomainObject> result = new List<IDomainObject>();

            while (reader.Read())
            {
                result.Add(new NapomenaZaUslugu
                {
                    SifraUsluge = new Usluga
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
                    },
                    RedniBroj = (int)reader["RedniBroj"],
                    OpisNapomene = (string)reader["OpisNapomene"],
                    SifraTipaNapomene = new TipNapomeneZaUslugu
                    {
                        SifraTipaNapomene = (int)reader["SifraTipaNapomene"],
                        NazivTipaNapomene = (string)reader["NazivTipaNapomene"]
                    }
                });
            }
            return result;
        }
    }
}
