using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointUI : MonoBehaviour {

    //ゲームオーバを表示するテキスト
    private GameObject pointText;
    private int point = 0;
    public void AddPoint(int point)
    {
        this.point += point;
        Debug.Log(this.point + "加算");
    }

    // Use this for initialization
    void Start ()
    {
        //シーン中のPointTextオブジェクトを取得
        this.pointText = GameObject.Find("PointText");
    }
	
	// Update is called once per frame
	void Update ()
    {
        this.pointText.GetComponent<Text>().text = "Score " + point + "点";
	}
}
