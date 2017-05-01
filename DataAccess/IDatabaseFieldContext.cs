using System.Collections.Generic;
using Voltron.Client.Models;

namespace Voltron.Client.DataAccess
{
    public interface IDatabaseFieldContext
    {
         IList<DatabaseField> GetAllDatabaseFields();
         DatabaseField GetDatabaseField();
         DatabaseField AddDatabaseField();
    }
}
