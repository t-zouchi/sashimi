﻿using UnityEngine;
using System.Collections;

public class Sashimi : MonoBehaviour {

  public float speed;
  public string Tag;
  public string CheckerTag;
  public GameObject Prefab;
  //public Rigidbody rb;
  // Use this for initialization
  void Start () {
    Destroy(gameObject, 10f);
	}
	
	// Update is called once per frame
	void Update () {
    transform.Translate(speed * Time.deltaTime, 0, 0);
    //var vector3 = new Vector3 (-5, 0, 0);
    //rb.velocity = vector3;
	}

  void OnTriggerEnter(Collider order)
  {
    if (order.gameObject.tag == Tag)
    {
      Destroy(gameObject);
      Vector3 position = new Vector3(0, 0, -8);
      Quaternion rotation = Quaternion.Euler(0, 0, 0);
      Instantiate(Prefab, position, rotation);
    }
    else if(order.gameObject.tag == CheckerTag)
    {

    }
  }
}


