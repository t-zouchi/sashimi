using UnityEngine;
using System.Collections;

public class SashimiAndFlower : MonoBehaviour {
  //public float speed;
  float speed = 0;
  public string CheckerTag;
  public GameObject Conrtollor;
  SpeedControllor speedControllor;

  // Use this for initialization
  void Start () {
    speedControllor = Conrtollor.GetComponent<SpeedControllor>();
    speed = (-1) * speedControllor.getSpeed();
    Destroy(gameObject, 7);
	}
	
	// Update is called once per frame
	void Update () {
    //speed *= speedUpRate;

    transform.Translate(speed * Time.deltaTime, 0, 0);
  }

  void OnTriggerEnter(Collider order)
  {
    if (order.gameObject.tag == CheckerTag)
    {
      Debug.Log("goal");
      speedControllor.speedUp();
    }
    else
    {
      Debug.Log("nannna goal");
    }
  }
}
