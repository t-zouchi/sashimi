using UnityEngine;
using System.Collections;

public class SashimiAndFlower : MonoBehaviour {
  //public float speed;
  float speed = 0;
  public string CheckerTag;
  public GameObject Conrtollor;
  SpeedControllor speedControllor;

  void Start () {
    speedControllor = Conrtollor.GetComponent<SpeedControllor>();
    speed = (-1) * speedControllor.getSpeed();
    Destroy(gameObject, 7);
	}
	
	void Update () {
    transform.Translate(speed * Time.deltaTime, 0, 0);
  }

}
