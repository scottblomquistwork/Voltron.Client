using Voltron.Client.Models;

namespace Voltron.Client.Services
{
    public interface IDatabaseFieldRequests
    {
         DatabaseField GetDatabaseField(int id);
         DatabaseField RequestNewDatabaseField(DatabaseField newField);
    }
}
