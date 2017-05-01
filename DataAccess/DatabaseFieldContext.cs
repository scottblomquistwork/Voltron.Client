using System;
using System.Collections.Generic;
using Voltron.Client.Models;

namespace Voltron.Client.DataAccess
{
    public class DatabaseFieldContext : IDatabaseFieldContext
    {
        public DatabaseField AddDatabaseField()
        {
            throw new NotImplementedException();
        }

        public IList<DatabaseField> GetAllDatabaseFields()
        {
            throw new NotImplementedException();
        }

        public DatabaseField GetDatabaseField()
        {
            var field = new DatabaseField("column", "table", "description", 'N', EmpowerDatabaseType.DbInteger, null); 
            return field;
        }
    }
}
