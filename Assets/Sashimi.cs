using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Sashimi : MonoBehaviour {

  float speed = 0;
  public string Tag;
  public string CheckerTag;
  public GameObject Prefab;
  public GameObject Conrtollor;
  SpeedControllor speedControllor;
  PointCount pointCount;

  void Start () {
    speedControllor = Conrtollor.GetComponent<SpeedControllor>();
    pointCount = Conrtollor.GetComponent<PointCount>();
    speed = speedControllor.getSpeed();    
    Destroy(gameObject, 10f);
  }
	
	void Update () {
    transform.Translate(speed * Time.deltaTime, 0, 0);
	}

  void OnTriggerEnter(Collider order)
  {
    if (order.gameObject.tag == Tag)
    {
      //事前に今あるCanvasを削除する
      if (GameObject.Find("Canvas(Clone)") != null)
      {
        Destroy(GameObject.Find("Canvas(Clone)"));
      }
      pointCount.pointUp();
      speedControllor.speedUp();
      Destroy(gameObject);
      Vector3 position = new Vector3(0, 0, -8);
      Quaternion rotation = Quaternion.Euler(0, 0, 0);
      Instantiate(Prefab, position, rotation);
    }
    else if(order.gameObject.tag == CheckerTag)
    {
      speedControllor.speed = 2;
      SceneManager.LoadScene("Gameend");
    }
  }
}
