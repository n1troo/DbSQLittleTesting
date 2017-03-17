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
    public IEnumerable<DBTranning> GetDBTrannings()
    {
        return Context.Table<DBTranning>();
    }

    /// <summary>
    /// Pobiera odpowiedni zestaw treningowy dla danego uzytkownika
    /// DAY, WEEK, LEVEL
    /// </summary>
    /// <param name="l"></param>
    /// <returns></returns>
    internal IEnumerable<object> GetDBTranningsByLvl(DBUserLevel l)
    {
        return Context.Table<DBTranning>()
            .Where
            (
                s => s.Day == l.TranningDay &&
                s.Level == l.TranningLevel &&
                s.Wekk == l.TranningWeek

            ).OrderBy(s=>(int)s.Set).ToArray();
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