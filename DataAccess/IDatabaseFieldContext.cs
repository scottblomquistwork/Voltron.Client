using System.Collections.Generic;
using Voltron.Client.Models;

namespace Voltron.Client.DataAccess
{
    public interface IDatabaseFieldContext
    {
         IList<DatabaseField> GetAllDatabaseFields();
         DatabaseField GetDatabaseField(int id);
         DatabaseField AddDatabaseField(DatabaseField newField);
    }
}
