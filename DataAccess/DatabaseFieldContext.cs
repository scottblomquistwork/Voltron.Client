using System;
using System.Collections.Generic;
using Voltron.Client.Models;

namespace Voltron.Client.DataAccess
{
    public class DatabaseFieldContext : IDatabaseFieldContext
    {
        DatabaseField IDatabaseFieldContext.AddDatabaseField()
        {
            throw new NotImplementedException();
        }

        IList<DatabaseField> IDatabaseFieldContext.GetAllDatabaseFields()
        {
            throw new NotImplementedException();
        }

        DatabaseField IDatabaseFieldContext.GetDatabaseField()
        {
            throw new NotImplementedException();
        }
    }
}
