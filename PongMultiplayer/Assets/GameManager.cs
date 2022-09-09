using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

  public static GameManager instance;
  public int player1Score = 0;
  public int player2Score = 0;
  public TMP_Text P1Text;
  public TMP_Text P2Text;


  private void Awake()
  {
    if (instance != null)
    {
      return;
    }
    else
    {
      instance = this;
    }
  }

  // Start is called before the first frame update
  void Start()
  {
    P1Text.text = player1Score.ToString();
    P2Text.text = player2Score.ToString();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void UpdateScore()
  {
    P1Text.text = player1Score.ToString();
    P2Text.text = player2Score.ToString();
  }
}
