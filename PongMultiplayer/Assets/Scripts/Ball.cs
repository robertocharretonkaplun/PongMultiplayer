using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Ball : MonoBehaviour
{
  private float initVelocity = 4f;
  private float velocityMultiplayer = 1.1f;

  private Rigidbody2D RB;

  // Start is called before the first frame update
  void Start()
  {
    RB = GetComponent<Rigidbody2D>();
    if (PhotonNetwork.PlayerList.Length >= 2)
    {

      Launch();
    }
  }

  public void Launch()
  {
    float x = Random.Range(0, 2) == 0 ? -1 : 1;
    float y = Random.Range(0, 2) == 0 ? -1 : 1;
    RB.velocity = new Vector2(x, y) * initVelocity;
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.collider.CompareTag("Bar"))
    {
      RB.velocity *= velocityMultiplayer;
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("RigthKillWall") || collision.CompareTag("LeftKillWall"))
    {
      if (collision.CompareTag("RigthKillWall"))
      {
        GameManager.instance.player1Score++;
      }

      if (collision.CompareTag("LeftKillWall"))
      {
        GameManager.instance.player2Score++;
      }

      GameManager.instance.UpdateScore();

      RB.velocity = new Vector2(0, 0);
      transform.position = new Vector3(0, 0, 0);
      Launch();
    }
  }
}
