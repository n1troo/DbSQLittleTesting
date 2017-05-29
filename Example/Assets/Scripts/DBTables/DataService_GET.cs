using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

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

    public DBUserLevel GetDBUserLevel(int idUser)
    {
        return DataService.db._connection.Table<DBUserLevel>().Where(x => x.idUsers == idUser).FirstOrDefault();
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


    public IEnumerable<Tranning> GetTableWithNowTrening(DBUsers l, int pweek)
    {
        
        List<Tranning> ltrain = new List<Tranning>();

        var listaTraningu = from p in DataService.db.GetDBTranningsAll().Where(s => s.Wekk == pweek)
                            where p.Wekk == pweek
                            select p;

        var listaTraningu2 = listaTraningu;

        for (int i = 0; i < 3; i++)
        {
            foreach (var ss in listaTraningu.Where(s=>s.Day == i + 1 && s.Level == 1).OrderBy(s=>s.Set))
            {
                Tranning tr = new Tranning();
                tr.Day = ss.Day;
                tr.Set = ss.Set;

                int lvl1 = 1;
                int lvl2 = 2;
                int lvl3 = 3;

                tr.Level1 =  (listaTraningu2.Where(s => s.Day == i + 1 && s.Set == ss.Set && s.Level == lvl1).FirstOrDefault().Reps);

                tr.Level2 =  (listaTraningu2.Where(s => s.Day == i + 1 && s.Set == ss.Set && s.Level == lvl2).FirstOrDefault().Reps);

                tr.Level3 =  (listaTraningu2.Where(s => s.Day == i + 1 && s.Set == ss.Set && s.Level == lvl3).FirstOrDefault().Reps);

                ltrain.Add(tr);
            }
            
        }

        return ltrain;
    }
}