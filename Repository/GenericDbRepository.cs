using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericDbRepository : IRepository
    {
        private readonly Broker broker = new Broker();

        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Delete(IDomainObject domainObject)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"delete from {domainObject.TableName} where {domainObject.WhereCondition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public List<IDomainObject> GetAll(IDomainObject domainObject)
        {
            List<IDomainObject> result;
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select {domainObject.SelectValues} from {domainObject.TableName} {domainObject.TableAlias} {domainObject.JoinTable} {domainObject.JoinCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = domainObject.GetObjects(reader);
            reader.Close();
            return result;
        }

        public List<IDomainObject> GetAllWithCondition(IDomainObject domainObject)
        {
            List<IDomainObject> result;
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select {domainObject.SelectValues} from {domainObject.TableName} {domainObject.TableAlias} {domainObject.JoinTable} {domainObject.JoinCondition} where {domainObject.SearchCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = domainObject.GetObjects(reader);
            reader.Close();
            return result;
        }

        public List<IDomainObject> GetSpecific(IDomainObject domainObject)
        {
            List<IDomainObject> result;
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select {domainObject.SelectValues} from {domainObject.TableName} {domainObject.TableAlias} {domainObject.JoinTable} {domainObject.JoinCondition} where {domainObject.GeneralCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = domainObject.GetObjects(reader);
            reader.Close();
            return result;
        }

        public void Save(IDomainObject domainObject)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {domainObject.TableName} values ({domainObject.InsertValues})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Update(IDomainObject domainObject)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"update {domainObject.TableName} set {domainObject.UpdateValues} where {domainObject.WhereCondition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }
    }
}
