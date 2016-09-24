using UnityEngine;
using System.Collections;

public class SpeedControllor : MonoBehaviour {

  public float speed = 2;
	
  public void speedUp()
  {
    speed = speed * 1.1f;
  }

  public float getSpeed()
  {
    return speed;
  }
}
