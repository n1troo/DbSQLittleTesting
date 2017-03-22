using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class DataService 
{
    public DBUserLevel DBUserLevel(int idUser)
    {
        return DataService.db._connection.Table<DBUserLevel>().Where(s => s.idUsers == idUser).First();
    }

    public IEnumerable<DBUsers> GetDBUsers()
    {
        return DataService.db._connection.Table<DBUsers>();
    }
    public IEnumerable<DBTranning> GetDBTrannings()
    {
        return DataService.db._connection.Table<DBTranning>().ToArray();
    }
    public DBUsers GetDbDBUsersByID(int idUsers)
    {
        return DataService.db._connection.Table<DBUsers>().Where(x => x.idUsers == idUsers).FirstOrDefault();
    }
    public DBUserLevel GetDbUserLevelByID(int idUserLevel)
    {
        return DataService.db._connection.Table<DBUserLevel>().Where(x => x.idUserLevel == idUserLevel).FirstOrDefault();
    }
}