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
}