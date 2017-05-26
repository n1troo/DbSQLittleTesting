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


public class Tranning
{
    public int Day { get; set; }
    public int Level { get; set; }
    public int Set { get; set; }
    public int Reps { get; set; }

    //public override string ToString()
    //{
    //    return string.Format("Set: {0},Level: {1}, Level: {2}, Reps: {3}", Set,Day, Level, Reps);
    //}
}