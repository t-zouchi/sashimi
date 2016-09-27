using UnityEngine;
using System.Collections;

public class Flower : MonoBehaviour {

  public string Tag;
  public float speed = 0;
  bool moveflg = false;

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
    transform.Translate(speed * Time.deltaTime, 0, 0);
  }
}
