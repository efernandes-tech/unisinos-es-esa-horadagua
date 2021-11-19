using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Horadagua.Infraestrutura
{
    public interface IDatabaseConnection
    {
        SQLiteConnection DbConnection();
    }
}
