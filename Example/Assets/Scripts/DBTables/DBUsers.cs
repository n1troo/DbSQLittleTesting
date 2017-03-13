using SQLite4Unity3d;
using System;
public class DBUsers
{
    [PrimaryKey, AutoIncrement]
    public int idUsers { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public DateTime AddDate { get; set; }
    
}