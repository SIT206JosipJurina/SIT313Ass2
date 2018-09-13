using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIT313Assignment2.Data
{
    public interface ISQLite
    {

        SQLiteConnection GetConnection();
    }
}
