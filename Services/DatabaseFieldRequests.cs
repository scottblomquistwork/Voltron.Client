using System;
using Voltron.Client.Models;

namespace Voltron.Client.Services
{
    public class DatabaseFieldRequests : IDatabaseFieldRequests
    {
        DatabaseField IDatabaseFieldRequests.GetDatabaseField(int id)
        {
            throw new NotImplementedException();
        }

        DatabaseField IDatabaseFieldRequests.RequestNewDatabaseField(DatabaseField newField)
        {
            throw new NotImplementedException();
        }
    }
}
