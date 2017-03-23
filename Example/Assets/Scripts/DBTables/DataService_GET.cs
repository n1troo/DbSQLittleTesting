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

    public IEnumerable<DBTranning> GetDBTranningsAll()
    {
        return DataService.db._connection.Table<DBTranning>();
    }

    public DBUsers GetDbDBUsersByID(int idUsers)
    {
        return DataService.db._connection.Table<DBUsers>().Where(x => x.idUsers == idUsers).FirstOrDefault();
    }

    public IEnumerable<DBTranning> GetUserDBTranning(DBUsers l)
    {
        return DataService.db.GetDBTranningsAll()
            .Where(
                s => s.Day == l.DBUserLevel.TranningDay &&
                s.Level == l.DBUserLevel.TranningLevel &&
                s.Wekk == l.DBUserLevel.TranningWeek
                ).OrderBy(s => (int)s.Set);
    }
}