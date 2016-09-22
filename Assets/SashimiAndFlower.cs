using UnityEngine;
using System.Collections;

public class SashimiAndFlower : MonoBehaviour {
  //public float speed;
  float speed = -2;
  float speedUpRate = 1.01f;
  // Use this for initialization
  void Start () {
    Destroy(gameObject, 7);
	}
	
	// Update is called once per frame
	void Update () {
    speed *= speedUpRate;
    transform.Translate(speed * Time.deltaTime, 0, 0);
  }
}
