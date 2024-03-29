﻿using SQLite4Unity3d;
using UnityEngine;
using System;

#if !UNITY_EDITOR
using System.Collections;
using System.IO;
#endif

public partial class DataService
{
    public String DatabaseName = "pushUpsGO.db";
    private SQLiteConnection _connection;

    private static DataService _db;
    public static DataService db
    {
        get
        {
            if(_db == null)
            {
                _db = new DataService();
                _db.DataServiceRunDB();
            }
            return _db;
        }
    }

    public void DataServiceRunDB()
    {
        if (_connection == null)
        {
            _connection = ConnectDataBase();
            if (_connection.GetTableInfo("DBUsers").Count == 0)
            {
                Debug.LogWarning("Zakładam baze danych!");
                CreateDBRunTables(_connection);
            }
        }
    }
    private SQLiteConnection ConnectDataBase()
    {
        #region CHECK WHAT VERSION IS THIS (dbPath)
#if UNITY_EDITOR
        var dbPath = string.Format(@"Assets/StreamingAssets/{0}", DatabaseName);
#else
        // check if file exists in Application.persistentDataPath
        var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);

        if (!File.Exists(filepath))
        {
            Debug.Log("Database not in Persistent path");
            // if it doesn't ->
            // open StreamingAssets directory and load the db ->

#if UNITY_ANDROID
            var loadDb = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DatabaseName);  // this is the path to your StreamingAssets in android
            while (!loadDb.isDone) { }  // CAREFUL here, for safety reasons you shouldn't let this while loop unattended, place a timer and error check
            // then save to Application.persistentDataPath
            File.WriteAllBytes(filepath, loadDb.bytes);
#elif UNITY_IOS
                 var loadDb = Application.dataPath + "/Raw/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);
#elif UNITY_WP8
                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);

#elif UNITY_WINRT
		var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
#else
	var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
	// then save to Application.persistentDataPath
	File.Copy(loadDb, filepath);

#endif

            Debug.Log("Database written");
        }

        var dbPath = filepath;
#endif
        _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
        #endregion

        //Debug.Log("Final PATH: " + dbPath);
        return _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
    }
}

   
