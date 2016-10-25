using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Comment : MonoBehaviour {
  public Text comment;
	// Use this for initialization
	void Start () {
    int point = PointCount.getPoint();
    int salary = 10 * point;
    string message = "";
    if (!PointCount.magroFlg)
    {
      message = "刺身に" + point.ToString() + "個たんぽぽを乗せました\n" + "給料は" + salary.ToString() + "円です。";
    }
    else
    {
      message = "貴様!! マグロに触っただろ!!\n首じゃぁ!!!!";
    }
    comment.text = message;
  }
}
