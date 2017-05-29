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
    public int Set { get; set; }
    public int Level1 { get; set; }
    public int Level2 { get; set; }
    public int Level3 { get; set; }
 

    public override string ToString()
    {
        return string.Format("Day: {0}", "Set: {1}", "Level1: {2}", "Level2: {3}", "Level3: {4}", Day, Set, Level1, Level2, Level3);
    }
}