using SQLite4Unity3d;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public partial class DataService
{
    public void CreateDBRunTables(SQLiteConnection _connection)
    {
        //Tworzenie tabel
        _connection.CreateTable<DBUsers>();
        _connection.CreateTable<DBUserLevel>();
        _connection.CreateTable<DBTranning>();
        _connection.CreateTable<DBUsersLogs>();


        var usr1 = CreateUser("Uzytkownik", "ABC");
        var usr1_lvl = CreateDefaultUserLvl(usr1);

        _connection.InsertAll(new[]
       {
            usr1_lvl,
        });

        CreateTranningTable();
        CreateFirstUserLog(usr1);


        Debug.LogWarning("Utworzyłem tabele bazy dannych");
    }

    private void CreateFirstUserLog(DBUsers usr1)
    {
        var log = new DBUsersLogs
        {
            AddDate = DateTime.Now,
            idUsers = usr1.idUsers,
            Login = usr1.Login
        };

        _connection.Insert(log);
    }

    /// <summary>
    /// Tworzenie danych z treningiem
    /// </summary>
    private void CreateTranningTable()
    {
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 1, 1, 1, 1, 2)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 1, 2, 3)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 1, 3, 2)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 1, 4, 2)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 1, 5, 3)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 2, 1, 6)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 2, 2, 6)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 2, 3, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 2, 4, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 2, 5, 5)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 3, 1, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 3, 2, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 3, 3, 7)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 3, 4, 7)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 1, 3, 5, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 1, 1, 3)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 1, 2, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 1, 3, 2)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 1, 4, 3)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 1, 5, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 2, 1, 6)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 2, 2, 8)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 2, 3, 6)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 2, 4, 6)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 2, 5, 7)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 3, 1, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 3, 2, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 3, 3, 8)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 3, 4, 8)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 2, 3, 5, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 1, 1, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 1, 2, 5)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 1, 3, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 1, 4, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 1, 5, 5)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 2, 1, 8)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 2, 2, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 2, 3, 7)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 2, 4, 7)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 2, 5, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 3, 1, 11)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 3, 2, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 3, 3, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 3, 4, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (1, 3, 3, 5, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 1, 1, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 1, 2, 6)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 1, 3, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 1, 4, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 1, 5, 6)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 2, 1, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 2, 2, 11)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 2, 3, 8)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 2, 4, 8)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 2, 5, 11)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 3, 1, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 3, 2, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 3, 3, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 3, 4, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 1, 3, 5, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 1, 1, 5)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 1, 2, 6)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 1, 3, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 1, 4, 4)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 1, 5, 7)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 3, 1, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 3, 2, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 3, 3, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 3, 4, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 3, 5, 17)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 2, 1, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 2, 2, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 2, 3, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 2, 4, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 2, 2, 5, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 1, 1, 5)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 1, 2, 7)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 1, 3, 5)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 1, 4, 5)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 1, 5, 8)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 2, 1, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 2, 2, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 2, 3, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 2, 4, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 2, 5, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 3, 1, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 3, 2, 17)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 3, 3, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 3, 4, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (2, 3, 3, 5, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 1, 1, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 1, 2, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 1, 3, 7)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 1, 4, 7)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 1, 5, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 2, 1, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 2, 2, 17)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 2, 3, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 2, 4, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 2, 5, 17)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 3, 1, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 3, 2, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 3, 3, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 3, 4, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 1, 3, 5, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 1, 1, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 1, 2, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 1, 3, 8)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 1, 4, 8)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 1, 5, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 2, 1, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 2, 2, 19)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 2, 3, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 2, 4, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 2, 5, 19)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 3, 1, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 3, 2, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 3, 3, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 3, 4, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 2, 3, 5, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 1, 1, 11)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 1, 2, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 1, 3, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 1, 4, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 1, 5, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 2, 1, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 2, 2, 21)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 2, 3, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 2, 4, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 2, 5, 21)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 3, 1, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 3, 2, 30)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 3, 3, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 3, 4, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 3, 3, 3, 5, 28)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 1, 1, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 1, 2, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 1, 3, 11)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 1, 4, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 1, 5, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 2, 1, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 2, 2, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 2, 3, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 2, 4, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 2, 5, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 3, 1, 21)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 3, 2, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 3, 3, 21)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 3, 4, 21)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 1, 3, 5, 32)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 1, 1, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 1, 2, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 1, 3, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 1, 4, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 1, 5, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 2, 1, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 2, 2, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 2, 3, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 2, 4, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 2, 5, 28)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 3, 1, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 3, 2, 29)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 3, 3, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 3, 4, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 2, 3, 5, 36)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 1, 1, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 1, 2, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 1, 3, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 1, 4, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 1, 5, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 2, 1, 23)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 2, 2, 28)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 2, 3, 23)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 2, 4, 23)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 2, 5, 33)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 3, 1, 29)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 3, 2, 33)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 3, 3, 29)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 3, 4, 29)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 4, 3, 3, 5, 40)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 1, 1, 17)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 1, 2, 19)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 1, 3, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 1, 4, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 1, 5, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 2, 1, 28)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 2, 2, 35)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 2, 3, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 2, 4, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 2, 5, 35)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 3, 1, 36)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 3, 2, 40)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 3, 3, 30)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 3, 4, 24)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 1, 3, 5, 40)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 1, 1, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 1, 2, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 1, 3, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 1, 4, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 1, 5, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 1, 6, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 1, 7, 9)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 1, 8, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 2, 1, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 2, 2, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 2, 3, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 2, 4, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 2, 5, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 2, 6, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 2, 7, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 2, 8, 40)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 3, 1, 19)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 3, 2, 19)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 3, 3, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 3, 4, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 3, 5, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 3, 6, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 3, 7, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 2, 3, 8, 45)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 1, 1, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 1, 2, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 1, 3, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 1, 4, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 1, 5, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 1, 6, 12)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 1, 7, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 1, 8, 30)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 2, 1, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 2, 2, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 2, 3, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 2, 4, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 2, 5, 17)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 2, 6, 17)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 2, 7, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 2, 8, 45)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 3, 1, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 3, 2, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 3, 3, 24)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 3, 4, 24)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 3, 5, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 3, 6, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 3, 7, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 5, 3, 3, 8, 50)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (6, 1, 1, 1, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (6, 1, 1, 2, 30)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (6, 1, 1, 3, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (6, 1, 1, 4, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (6, 1, 1, 5, 40)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (6, 1, 2, 1, 40)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES (6, 1, 2, 2, 50)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 1, 2, 3, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 1, 2, 4, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 1, 2, 5, 50)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 1, 3, 1, 45)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 1, 3, 2, 55)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 1, 3, 3, 35)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 1, 3, 4, 30)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 1, 3, 5, 55)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 1, 1, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 1, 2, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 1, 3, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 1, 4, 15)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 1, 5, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 1, 6, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 1, 7, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 1, 8, 10)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 1, 9, 44)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 2, 1, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 2, 2, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 2, 3, 23)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 2, 4, 23)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 2, 5, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 2, 6, 20)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 2, 7, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 2, 8, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 2, 9, 53)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 3, 1, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 3, 2, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 3, 3, 30)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 3, 4, 30)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 3, 5, 24)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 3, 6, 24)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 3, 7, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 3, 8, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 2, 3, 9, 58)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 1, 1, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 1, 2, 13)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 1, 3, 17)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 1, 4, 17)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 1, 5, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 1, 6, 16)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 1, 7, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 1, 8, 14)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 1, 9, 50)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 2, 1, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 2, 2, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 2, 3, 30)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 2, 4, 30)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 2, 5, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 2, 6, 25)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 2, 7, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 2, 8, 18)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 2, 9, 55)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 3, 1, 26)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 3, 2, 26)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 3, 3, 33)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 3, 4, 33)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 3, 5, 26)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 3, 6, 26)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 3, 7, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 3, 8, 22)");
        _connection.Execute(@"INSERT INTO DBTranning (Wekk, Day, Level, [Set], Reps) VALUES ( 6, 3, 3, 9, 60)");
    }

    private DBUsers CreateUser(string UserLogin, string UserPassword)
    {
        var p = new DBUsers
        {
            Login = UserLogin,
            Password = UserPassword,
            AddDate = DateTime.Now
        };

        _connection.Insert(p);
        p = _connection.Table<DBUsers>().Where(s => s.Login == UserLogin).FirstOrDefault();

        return p;
    }

    private DBUserLevel CreateDefaultUserLvl(DBUsers user)
    {
        var t = new DBUserLevel
        {
            idUsers = user.idUsers,
            TranningDay = 1,
            TranningLevel = 1,
            TranningSet = 1,
            TranningWeek = 1,
            TranningRestTime = 120,
        };

        return t;
    }
}

