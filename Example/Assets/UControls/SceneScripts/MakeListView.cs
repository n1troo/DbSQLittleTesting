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
        listview.Header = UITool.CreateDefaultHeader(Color.black, Color.white, "A", "B", "C", "D", "E");
	}
	
	
}
