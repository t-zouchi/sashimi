using UnityEngine;
using System.Collections;

public class TweetButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetButtonDown("Fire1"))
    {
        string message = "テストテスト #nikonamakudou";
        Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
    }
  }
}
