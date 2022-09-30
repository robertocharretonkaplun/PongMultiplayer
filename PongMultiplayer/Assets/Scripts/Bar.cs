using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Bar : MonoBehaviour
{
  // For local, you have a boolean that sets a who is P1 and P2
  public bool IsBar1 = false;

  // The speed value for the bar
  private float speed = 7f;

  // The top/down limit for not passing the limits of the screen.
  private float Ylimit = 3.75f;


  private PhotonView photonView;

  private void Start()
  {
    photonView = GetComponent<PhotonView>();
  }

  // Update is called once per frame
  void Update()
  {
    if (GameManager.instance.Multiplayer)
    {
      if (photonView.IsMine)
      {
        Movement();
      }
    }
    else
    {
      Movement();
    }
  }

  void Movement()
  {
    float movement;
    if (IsBar1)
    {
      movement = Input.GetAxisRaw("Vertical2");
    }
    else
    {
      movement = Input.GetAxisRaw("Vertical");
    }

    Vector2 BarPos = transform.position;

    BarPos.y = Mathf.Clamp(BarPos.y + movement * speed * Time.deltaTime, -Ylimit, Ylimit);
    transform.position = BarPos;
  }
}
