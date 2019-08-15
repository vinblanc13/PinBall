using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    private GameObject pointText;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.pointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.pointText.GetComponent<PointUI>().AddPoint(1);
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.pointText.GetComponent<PointUI>().AddPoint(5);
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.pointText.GetComponent<PointUI>().AddPoint(2);
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.pointText.GetComponent<PointUI>().AddPoint(3);
        }
    }
}