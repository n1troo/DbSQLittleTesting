using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel02Manager : MonoBehaviour
{
    public Transform PanelContentMiddle;
    public GameObject Panel02User;
    public GameObject Panel02Settins;
    public GameObject Panel02PushUPScheduler;
    // Use this for initialization

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }

    /// <summary>
    /// Adding panels to PanelContentMiddle by name of gameobject
    /// </summary>
    /// <param name="namePanel"></param>
    public void AddPanel(string namePanel)
    {
        GameObject Local = null;
        if (PanelContentMiddle.transform.childCount > 0)
        {
            foreach (Transform ss in PanelContentMiddle)
            {
                GameObject.DestroyObject(ss.gameObject);
            }
        }

        if (namePanel == "Panel02User")
        {
            Local = Instantiate(Panel02User);
        }
        if (namePanel == "Panel02Settins")
        {
            Local = Instantiate(Panel02Settins);
        }
        if(namePanel == "Panel02PushUPScheduler")
        {
            Local = Instantiate(Panel02PushUPScheduler);
        }

        Local.transform.SetParent(PanelContentMiddle.transform, false);
    }
}
