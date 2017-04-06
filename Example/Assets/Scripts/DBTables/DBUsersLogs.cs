using SQLite4Unity3d;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


public class DBUsersLogs
{
    [PrimaryKey, AutoIncrement]
    public int idDBUsersLogs { get; set; }
    public int idUsers { get; set; }
    public string Login { get; set; }
    public DateTime AddDate { get; set; }
}
