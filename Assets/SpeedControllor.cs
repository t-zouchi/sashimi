using UnityEngine;
using System.Collections;

public class SpeedControllor : MonoBehaviour {

  public float speed = 2;
  int count = 0;

  public void speedUp()
  {
    if(count%4 == 0)
    {
      speed = speed * 1.1f;
    }
    count++;
  }

  public float getSpeed()
  {
    return speed;
  }
}
