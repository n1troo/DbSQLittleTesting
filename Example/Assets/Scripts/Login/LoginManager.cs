using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour {


    DBUsers LoggedUser { get; set; }

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
            Application.Quit();
        }
    }

    public void LogInToMenu(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber, LoadSceneMode.Single);
    }
}