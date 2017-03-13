using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class ExistingDBScript : MonoBehaviour
{
    public Text DebugText;
    void Start()
    {
        var db = new DataService();
        foreach (var ss in db.DBUsers)
        {
            Debug.Log("User :" +ss.idUsers + " " + ss.Login);
        } 

        //ds.UpdateWpis(3, "Nowość wpis 002");
        //ds.UpdateWpis(4, "Nowość wpis 002");
    }
}
