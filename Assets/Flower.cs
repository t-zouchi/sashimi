﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Flower : MonoBehaviour {

  public string Tag;
  public float speed = 0;
  bool moveflg = false;
  public GameObject Conrtollor;
  PointCount pointCount;
  public Text Score;

  // Update is called once per frame
  void Update () {
    if (moveflg)
    {
      transform.Translate(speed * Time.deltaTime, 0, 0);
    }
	}

  void OnTriggerEnter(Collider order)
  {
    if (order.gameObject.tag == Tag)
    {
      Destroy(gameObject);
      moveflg = true;
    }
  }

  void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.tag == "conveyor")
    {
      if (!LoadGame.hanafubikiFlg)
      {
        SceneManager.LoadScene("Gameend");
      }
    }

    if (collision.gameObject.tag == "maguro")
    {
      pointCount = Conrtollor.GetComponent<PointCount>();
      pointCount.magroHit();
      SceneManager.LoadScene("Gameend");
    }
  }
}
