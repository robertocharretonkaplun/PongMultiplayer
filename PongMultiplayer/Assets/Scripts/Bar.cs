using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Bar : MonoBehaviour
{
  public bool IsBar1 = false;
  private float speed = 7f;
  private float Ylimit = 3.75f;
  private PhotonView photonView;

  private void Start()
  {
    photonView = GetComponent<PhotonView>();
  }

  // Update is called once per frame
  void Update()
  {

    if (photonView.IsMine)
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
}
