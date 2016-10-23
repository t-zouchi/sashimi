using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadGame : MonoBehaviour {

  public void GameStart()
  {
    SceneManager.LoadScene("sashimi");
  }

  public void MoveTitle()
  {
    SceneManager.LoadScene("title");
  }

  public void TweetButton()
  {
    string message = "test #nikonamakudou";
    Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
  }
}
