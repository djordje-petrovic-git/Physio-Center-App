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
    public class TipKlijenta : IDomainObject
    {
        public int SifraTipaKlijenta { get; set; }
        public string NazivTipaKlijenta { get; set; }
        [Browsable(false)]
        public string TableName => "TipKlijenta";
        [Browsable(false)]

        public string TableAlias => "tk";
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
            return NazivTipaKlijenta;
        }
        public List<IDomainObject> GetObjects(SqlDataReader reader)
        {
            List<IDomainObject> result = new List<IDomainObject>();

            while (reader.Read())
            {
                result.Add(new TipKlijenta
                {
                    SifraTipaKlijenta = (int)reader["SifraTipaKlijenta"],
                    NazivTipaKlijenta = (string)reader["NazivTipaKlijenta"]
                });
            }
            return result;
        }
    }
}
