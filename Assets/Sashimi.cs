using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Sashimi : MonoBehaviour {

  //public float speed;
  float speed = 0;
  public string Tag;
  public string CheckerTag;
  public GameObject Prefab;
  public GameObject Conrtollor;
  SpeedControllor speedControllor;

  //SpeedControllor spc  = null;
  // Use this for initialization
  void Start () {
    speedControllor = Conrtollor.GetComponent<SpeedControllor>();
    speed = speedControllor.getSpeed();
    
    Destroy(gameObject, 10f);
    //speed = speed * speedUpRate * Time.realtimeSinceStartup;
    
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
      Vector3 position = new Vector3(0, 0, -8);
      Quaternion rotation = Quaternion.Euler(0, 0, 0);
      Instantiate(Prefab, position, rotation);
      speedControllor.speedUp();
    }
    else if(order.gameObject.tag == CheckerTag)
    {
      speedControllor.speed = 2;
      SceneManager.LoadScene("title");
    }
  }
}


