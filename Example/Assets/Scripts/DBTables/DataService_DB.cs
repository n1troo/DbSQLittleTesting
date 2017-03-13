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

        _connection.InsertAll(new[]
        {
            CreateUser("Uzytkownik",""),
            CreateUser("Uzytkownik2","")
        });

        Debug.LogAssertion("Utworzyłem tabele bazy dannych");
    }
    private DBUsers CreateUser(string UserLogin, string UserPassword)
    {
        var p = new DBUsers
        {
            Login = UserLogin,
            Password = UserPassword,
            AddDate = DateTime.Now
        };

        return p;
    }
}

