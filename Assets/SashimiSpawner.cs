using UnityEngine;
using System.Collections;

public class SashimiSpawner : MonoBehaviour {

  public GameObject sashimiPrefab;
  public GameObject maguroPrefab;
  public float interval;
  public int randomValue;

  // Use this for initialization
  IEnumerator Start()
  {
    while (true) {
      float random = Random.Range(0f, 100f);
      if (randomValue > random)
      {
        Instantiate(maguroPrefab, transform.position, transform.rotation);
      }
      else {
        Instantiate(sashimiPrefab, transform.position, transform.rotation);
      }
      yield return new WaitForSeconds(interval);
    }
  }
		
}
