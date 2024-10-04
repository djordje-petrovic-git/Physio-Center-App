using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [TypeConverter(typeof(EnumToStringUsingDescription))]
    public enum Vaucer
    {
        [Description("Bez popusta")]
        BezVaucera,
        [Description("10% popusta")]
        Popust10,
        [Description("20% popusta")]
        Popust20,
        [Description("Uput lekara")]
        UputLekara,
    }
    public class EnumToStringUsingDescription : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType.Equals(typeof(Enum)));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return (destinationType.Equals(typeof(String)));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (!destinationType.Equals(typeof(String)))
            {
                throw new ArgumentException("Can only convert to string.", "destinationType");
            }

            if (!value.GetType().BaseType.Equals(typeof(Enum)))
            {
                throw new ArgumentException("Can only convert an instance of enum.", "value");
            }

            string name = value.ToString();
            object[] attrs =
                value.GetType().GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attrs.Length > 0) ? ((DescriptionAttribute)attrs[0]).Description : name;
        }
    }
    [Serializable]
    public class Termin : IDomainObject
    {
        public Klijent SifraKlijenta { get; set; }
        public Usluga SifraUsluge { get; set; }
        
        public DateTime DatumVremeTermina { get; set; }
        public string Napomena { get; set; }
        public Vaucer Vaucer { get; set; }
        public double KonacnaCena { get; set; }

        [Browsable(false)]
        public string TableName => "Termin";
        [Browsable(false)]
        public string TableAlias => "t";
        [Browsable(false)]
        public string JoinTable => "join Klijent kl";
        [Browsable(false)]
        public string JoinCondition => "on (t.SifraKlijenta=kl.SifraKlijenta) join Usluga u on (t.SifraUsluge=u.SifraUsluge)" +
            " join TipKlijenta tk on (kl.SifraTipaKlijenta=tk.SifraTipaKlijenta) join VrstaUsluge vu on " +
            "(vu.SifraVrsteUsluge=u.SifraVrsteUsluge)";
        [Browsable(false)]
        public string WhereCondition => $"SifraKlijenta={SifraKlijenta.SifraKlijenta} and SifraUsluge=" +
            $"{SifraUsluge.SifraUsluge} and DatumVremeTermina='{DatumVremeTermina}'";
        [Browsable(false)]
        public string GeneralCondition => $"t.SifraKlijenta={SifraKlijenta.SifraKlijenta} and t.SifraUsluge=" +
            $"{SifraUsluge.SifraUsluge} and t.DatumVremeTermina='{DatumVremeTermina}'";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string InsertValues => $"{SifraKlijenta.SifraKlijenta}, ${SifraUsluge.SifraUsluge}, '{DatumVremeTermina:yyyyMMdd HH:mm}', " +
            $"'{Napomena}', '{Vaucer}', {KonacnaCena}";
        [Browsable(false)]
        public string OutputInserted => "";
        [Browsable(false)]
        public string SearchCondition { get => searchCondition; set => searchCondition = value; }

        private string searchCondition;

        public List<IDomainObject> GetObjects(SqlDataReader reader)
        {
            List<IDomainObject> result = new List<IDomainObject>();

            while (reader.Read())
            {
                result.Add(new Termin
                {
                    SifraKlijenta = new Klijent
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
                    },
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
                    DatumVremeTermina = (DateTime)reader["DatumVremeTermina"],
                    Vaucer = (Vaucer)Enum.Parse(typeof(Vaucer), (string)reader["Vaucer"]),
                    Napomena = (string)reader["Napomena"],
                    KonacnaCena = (double)reader["KonacnaCena"]

                });
            }
            return result;
        }

        
    }
}
