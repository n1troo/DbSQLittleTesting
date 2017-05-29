using System.Collections;
using System.Collections.Generic;
using Ultralpha;
using UnityEngine;
using UnityEngine.UI;

public class MakeListView : MonoBehaviour {


    [SerializeField]
    private Ultralpha.ListView listview;
    public Text Text_NumerWeekListView;
    public int parametrWeek = 1;

    void Start ()
    {

        listview = Ultralpha.UITool.CreateDefaultListView();
        listview.transform.SetParent(this.transform, false);
        listview.Header = UITool.CreateDefaultHeader(new Color32(0, 52, 84, 255), Color.white, "Day", "Set", "Level1", "Level2", "Level3");

        listview.DataSource = DataService.db.GetTableWithNowTrening(LoginManager.LoggedUser, parametrWeek);
        SetWeekNumberListView();

    }

    private void SetWeekNumberListView()
    {
        Text_NumerWeekListView.text = "WEEK: " + parametrWeek.ToString();
    }

    public void ChangeWeekListView(int enumer)
    {
        if(enumer == (int)eChangeWeek.NEXT)
        {
            if(parametrWeek >= 1 && parametrWeek < 6)
            {
                parametrWeek++;
            }            
        }

        if (enumer == (int)eChangeWeek.BACK)
        {
            if (parametrWeek > 1 && parametrWeek <= 6)
            {
                parametrWeek--;
            }
        }

        listview.DataSource = DataService.db.GetTableWithNowTrening(LoginManager.LoggedUser, parametrWeek);

        SetWeekNumberListView();
    }



    public enum eChangeWeek
    {
        BACK = 0,
        NEXT = 1
    }
}
