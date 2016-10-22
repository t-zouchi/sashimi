using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointCount : MonoBehaviour {

  int point = 0;
  Text scoreText;
  public Canvas canvas;
  Canvas currentCanvas;
  string template = "Score :";

  // Use this for initialization
  void Start () {
    point = 0;
    currentCanvas = Instantiate(canvas);
    foreach (Transform child in currentCanvas.transform)
    {
      if(child.name == "Score")
      {
        scoreText = child.gameObject.GetComponent<Text>();
        scoreText.transform.SetParent(currentCanvas.transform, false);
        scoreText.text = template + point.ToString();
      }
    }

  }

  public int getPoint()
  {
    return point;
  }

  public void pointUp()
  {
    point++;
    currentCanvas = Instantiate(canvas);
    foreach (Transform child in currentCanvas.transform)
      {
        if (child.name == "Score")
        {
          scoreText = child.gameObject.GetComponent<Text>();
          scoreText.transform.SetParent(currentCanvas.transform, false);
          scoreText.text = template + point.ToString();
        }
      }
    }
  }
