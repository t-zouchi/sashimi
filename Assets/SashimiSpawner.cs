using UnityEngine;
using System.Collections;

public class SashimiSpawner : MonoBehaviour {

  public GameObject sashimiPrefab;
  public float interval;

  // Use this for initialization
  IEnumerator Start()
  {
    while (true) { 
      Instantiate(sashimiPrefab, transform.position, transform.rotation);
      yield return new WaitForSeconds(interval);
    }
  }
		
}
