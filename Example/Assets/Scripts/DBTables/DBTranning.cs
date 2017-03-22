using SQLite4Unity3d;
using System.Collections.Generic;

public class DBTranning
{
    [AutoIncrement, PrimaryKey]
    public int idTranning { get; set; }
    public int Wekk { get; set; }
    public int Day { get; set; }
    public int Level { get; set; }
    public int Set { get; set; }
    public int Reps { get; set; }

    /// <summary>
    /// Pobiera odpowiedni zestaw treningowy dla danego uzytkownika
    /// DAY, WEEK, LEVEL
    /// </summary>
    /// <param name="l"></param>
    /// <returns></returns>
    //[Ignore]
    //public ICollection<DBTranning> DBTrannings
    //{
    //    get
    //    {
    //        return DataService.db.GetDBTrannings.
    //    }
    //}
}