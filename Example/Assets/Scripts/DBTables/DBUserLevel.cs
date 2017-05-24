using SQLite4Unity3d;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Diagnostics;

public class DBUserLevel : DataService
{

    [AutoIncrement,PrimaryKey]
    public int idUserLevel { get; set; }

    public int idUsers { get; set; }
    public int TranningWeek { get; set; }
    public int TranningDay { get; set; }
    public int TranningLevel { get; set; }
    public int TranningSet { get; set; }
    public int TranningRestTime { get; set; }

    public void SetTranningComplete()
    {
        DBUserLevel ulvl = DataService.db.GetDBUserLevel(idUsers);
        
        if(this.TranningDay == 3)
        {
            ulvl.TranningDay = 1;
            ulvl.TranningWeek++;

            TranningDay = 1;
        }
        else
        {
            ulvl.TranningDay++;
            TranningDay++;
        }

        DataService.db.UpdateDBUserLevel(ulvl);
    }


    //[Ignore]
    //public IEnumerable<DBTranning> DBTranning
    //{
    //    get
    //    {
    //        DBUsers l = DataService.db.GetDbDBUsersByID(idUsers);
    //        return l.DBUserLevel.DBTranning.Where
    //            (
    //                s => s.Day == l.DBUserLevel.TranningDay &&
    //                s.Level == l.DBUserLevel.TranningLevel &&
    //                s.Wekk == l.DBUserLevel.TranningWeek
    //            ).OrderBy(s => (int)s.Set);
    //    }
    //}

}
