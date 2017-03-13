using SQLite4Unity3d;
using System.Collections.Generic;
using System;

public class DBUserLevel : DataService
{

    [AutoIncrement,PrimaryKey]
    public int idUserLevel { get; set; }

    public int idUsers { get; set; }
    public int TranningWeek { get; set; }
    public int TranningDay { get; set; }
    public int TranningLevel { get; set; }
    public int TranningSet { get; set; }
}
