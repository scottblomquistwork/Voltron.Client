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

        }

        public DatabaseField GetDatabaseField(int id)
        {
            throw new NotImplementedException();
        }

        public DatabaseField RequestNewDatabaseField(DatabaseField newField)
        {
            throw new NotImplementedException();
        }
    }
}
