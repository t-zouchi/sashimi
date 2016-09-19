using UnityEngine;
using System.Collections;

public class Sashimi : MonoBehaviour {

  public float speed;
	// Use this for initialization
	void Start () {
    Destroy(gameObject, 10f);
	}
	
	// Update is called once per frame
	void Update () {
    transform.Translate(speed * Time.deltaTime, 0, 0);
	}
}


