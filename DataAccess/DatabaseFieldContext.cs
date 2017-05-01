using System;
using System.Collections.Generic;
using Voltron.Client.Models;

namespace Voltron.Client.DataAccess
{
    public class DatabaseFieldContext : IDatabaseFieldContext
    {
        public DatabaseField AddDatabaseField(DatabaseField newField)
        {
            throw new NotImplementedException();
        }

        public IList<DatabaseField> GetAllDatabaseFields()
        {
            throw new NotImplementedException();
        }

        public DatabaseField GetDatabaseField(int id)
        {
            var field = new DatabaseField("column", "table", "description", 'N', EmpowerDatabaseType.DbInteger, null); 
            return field;
        }
    }
}
