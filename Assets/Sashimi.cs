using UnityEngine;
using System.Collections;

public class Sashimi : MonoBehaviour {

  public float speed;
  public string Tag;
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
      Instantiate(Prefab, transform.position, transform.rotation);
    }
  }
}


