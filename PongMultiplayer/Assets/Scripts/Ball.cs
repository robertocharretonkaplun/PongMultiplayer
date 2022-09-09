using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  private float initVelocity = 4f;
  private float velocityMultiplayer = 1.1f;

  private Rigidbody2D RB;

  // Start is called before the first frame update
  void Start()
  {
    RB = GetComponent<Rigidbody2D>();
    Launch();
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
}
