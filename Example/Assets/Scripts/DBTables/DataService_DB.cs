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


        var usr1 = CreateUser("Uzytkownik", "ABC");
        var usr1_lvl = CreateDefaultUserLvl(usr1);

        var usr2 = CreateUser("Uzytkownik2", "CBA");
        var usr2_lvl = CreateDefaultUserLvl(usr2);

        _connection.InsertAll(new[]
       {
            usr1_lvl,
            usr2_lvl
        });

        Debug.LogWarning("Utworzyłem tabele bazy dannych");
    }

    private DBUsers CreateUser(string UserLogin, string UserPassword)
    {
        var p = new DBUsers
        {
            Login = UserLogin,
            Password = UserPassword,
            AddDate = DateTime.Now
        };

        int id = _connection.Insert(p);
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
        };

        return t;
    }
}

