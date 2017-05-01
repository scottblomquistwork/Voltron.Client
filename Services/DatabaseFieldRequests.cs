using System;
using Voltron.Client.Models;
using Voltron.Client.DataAccess;

namespace Voltron.Client.Services
{
    public class DatabaseFieldRequests : IDatabaseFieldRequests
    {
        private DatabaseFieldContext DbContext;
        public DatabaseFieldRequests()
        {
            DbContext = new DatabaseFieldContext();
        }

        public DatabaseField GetDatabaseField(int id)
        {
            var field = DbContext.GetDatabaseField(id);
            return field;
        }

        public DatabaseField RequestNewDatabaseField(DatabaseField newField)
        {
            newField = new DatabaseField("column", "table", "description", 'N', EmpowerDatabaseType.DbInteger, null); 
            var returnedField  = DbContext.AddDatabaseField(newField);
            return returnedField;
        }
    }
}
