﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadGame : MonoBehaviour {

  public static bool hanafubikiFlg = false;

  public void GameStart()
  {
    hanafubikiFlg = false;
    SceneManager.LoadScene("sashimi");
  }

  public void MoveTitle()
  {
    SceneManager.LoadScene("title");
  }

  public void TweetButton()
  {
    int point = PointCount.getPoint();
    int salary = 10 * point;
    string message ="刺身に" + point.ToString() + "個たんぽぽを乗せました\n" +"給料は" + salary.ToString()+ "円です。\n -刺身にたんぽぽをのせるゲーム- https://goo.gl/fFNKqP #nikonamakudou";
    Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
  }

  public void StartHanafubukiMode()
  {
    hanafubikiFlg = true;
    SceneManager.LoadScene("sashimi");
  }
}
