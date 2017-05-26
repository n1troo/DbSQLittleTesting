using System.Collections;
using System.Collections.Generic;
using Ultralpha;
using UnityEngine;

public class MakeListView : MonoBehaviour {


    [SerializeField]
    private Ultralpha.ListView listview;

    void Start () {

        listview = Ultralpha.UITool.CreateDefaultListView();
        listview.transform.SetParent(this.transform, false);
        listview.Header = UITool.CreateDefaultHeader(new Color32(0, 52, 84, 255), Color.white, "Set", "Day", "Level", "Reps");

        int parametrWeek = 2;
        listview.DataSource = DataService.db.GetTableWithNowTrening(LoginManager.LoggedUser,parametrWeek);

        //foreach (DBTranning ss in DataService.db.GetUserDBTranning(LoginManager.LoggedUser))
        //{
        

        //}
	}
}
