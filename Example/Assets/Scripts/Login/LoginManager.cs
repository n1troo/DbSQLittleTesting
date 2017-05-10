using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public static DBUsers LoggedUser { get; set; }

    // Use this for initialization
    void Start ()
    {
        //Pobieranie ostatnioZalogowanego uzytkownika
        LoggedUser = DataService.db.GetDbDBUsersByID(1);
        
        // Store value on a constante "score"
        PlayerPrefs.SetInt("UserIdLogged", LoggedUser.idUsers);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex == 0)
        {
            //Tutaj może być jakaś opcja z wylogowywaniem
            Application.Quit();
        }
    }

    public void LogInToMenu(int sceneNumber)
    {
        //Zmiana sceny na jakaś inna, wszelkie pomocne dane zapamiętwane sa w PlayerPrefs także nie ma co wysyłać głupot.
        SceneManager.LoadScene(sceneNumber, LoadSceneMode.Single);
    }
}