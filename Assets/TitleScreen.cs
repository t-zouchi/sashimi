using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	// Update is called once per frame
	void Update () {
    if (Input.GetButtonDown("Fire1"))
    {
      SceneManager.LoadScene("sashimi");
    }
	}
}
