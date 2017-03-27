using SQLite4Unity3d;
using System;
using System.Collections.Generic;

public partial class DBUsers
{
    [PrimaryKey, AutoIncrement]
    public int idUsers { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public DateTime AddDate { get; set; }

    [Ignore]
    public DBUserLevel DBUserLevel
    {
        get
        {
            return DataService.db.DBUserLevel(this.idUsers);
        }
    }

    [Ignore]
    public int ActualSetPositon { get; set; }

   
}