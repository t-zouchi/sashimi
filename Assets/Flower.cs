using UnityEngine;
using System.Collections;

public class Flower : MonoBehaviour {

  public string Tag;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnTriggerEnter(Collider order)
  {
    if (order.gameObject.tag == Tag)
    {
      Destroy(gameObject);
    }
  }

}
