﻿using UnityEngine;
using System.Collections;

public class FlowerSpawner : MonoBehaviour {

  public GameObject FlowerPrefab;

  // Update is called once per frame
  void Update () {
    if (Input.GetButtonDown("Fire1")) Drop();	
	}

  public void Drop()
  {
    GameObject flower = (GameObject)Instantiate(
      FlowerPrefab,
      transform.position,
      Quaternion.identity
      );
    Destroy(flower, 1);
  }
}
