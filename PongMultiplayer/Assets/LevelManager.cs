using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelManager : MonoBehaviour
{
  public static LevelManager instance;

  [Header("ATTRIBUTES")]
  public int player1Score = 0;
  public int player2Score = 0;
  public TMP_Text P1Text;
  public TMP_Text P2Text;
  public GameObject Ball;

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
    UpdateScore();

    // check if the game is in local or multiplayer
    if (GameManager.instance.Multiplayer)
    {
      if (GameManager.instance.AreAllPlayersInGame())
      {
        GameManager.instance.InstantiateObject(Ball.name, new Vector3(0f, 0f, 0f), Quaternion.identity);
      }
    }
    else
    {
      var obj = Instantiate(Ball, new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
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
