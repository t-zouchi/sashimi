using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

  public Canvas canvas;
	
	void Start () {
    //canvas.enabled = false;
	}
	
  public void showGameOver()
  {
    canvas.enabled = true;
  }

}
