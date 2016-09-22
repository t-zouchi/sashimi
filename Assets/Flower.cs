using UnityEngine;
using System.Collections;

public class Flower : MonoBehaviour {

  public float speed;
  public string activeTag;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnColligionEnter(Collision collision)
  {
    Debug.Log("さわさわ");
  }
}
