using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class DataService 
{
    public IEnumerable<DBUserLevel> DBUserLevel()
    {
        return Context.Table<DBUserLevel>();
    }

    public IEnumerable<DBUsers> GetDBUsers()
    {
        return Context.Table<DBUsers>();
    }

    public DBUsers GetDbDBUsersByID(int idUsers)
    {
        return Context.Table<DBUsers>().Where(x => x.idUsers == idUsers).FirstOrDefault();
    }
    public DBUserLevel GetDbUserLevelByID(int idUserLevel)
    {
        return Context.Table<DBUserLevel>().Where(x => x.idUserLevel == idUserLevel).FirstOrDefault();
    }
}