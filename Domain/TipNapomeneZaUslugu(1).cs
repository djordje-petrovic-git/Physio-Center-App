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
    public class TipNapomeneZaUslugu : IDomainObject
    {
        public int SifraTipaNapomene { get; set; }
        public string NazivTipaNapomene { get; set; }
        [Browsable(false)]
        public string TableName => "TipNapomeneZaUslugu";
        [Browsable(false)]
        public string TableAlias => "tnzu";
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

        public override string ToString()
        {
            return NazivTipaNapomene;
        }

        public List<IDomainObject> GetObjects(SqlDataReader reader)
        {
            List<IDomainObject> result = new List<IDomainObject>();

            while (reader.Read())
            {
                result.Add(new TipNapomeneZaUslugu
                {
                    SifraTipaNapomene = (int)reader["SifraTipaNapomene"],
                    NazivTipaNapomene = (string)reader["NazivTipaNapomene"]
                });
            }
            return result;
        }
    }
}
