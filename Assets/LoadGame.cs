using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadGame : MonoBehaviour {

  public void GameStart()
  {
    SceneManager.LoadScene("sashimi");
  }
}
