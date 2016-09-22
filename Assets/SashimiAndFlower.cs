using UnityEngine;
using System.Collections;

public class SashimiAndFlower : MonoBehaviour {
  public int speed;
	// Use this for initialization
	void Start () {
    Destroy(gameObject, 7);
	}
	
	// Update is called once per frame
	void Update () {
    transform.Translate(speed * Time.deltaTime, 0, 0);
  }
}
