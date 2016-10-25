using UnityEngine;
using System.Collections;

public class SpeedControllor : MonoBehaviour {

  public float speed = 2;
  int count = 1;
  int level = 1;
  int limit = 6;

  void Start()
  {
    count = 1;
    level = 1;
  }

  public void speedUp()
  {
    Debug.Log(level);
    if (level <= limit)
    {
      if (count % level == 0)
      {
        speed = speed * 1.1f;
        count = 1;
        level++;
      }
    }
    else
    {
      if (count % limit == 0)
      {
        speed = speed * 1.1f;
        count = 1;
        level++;
      }
    }
    
    count++;
  }

  public float getSpeed()
  {
    return speed;
  }
}
