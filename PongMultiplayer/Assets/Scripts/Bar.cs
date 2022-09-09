using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
  public bool IsBar1 = false;
  private float speed = 7f;
  private float Ylimit = 3.75f;

  // Update is called once per frame
  void Update()
  {
    float movement;

    if (IsBar1) {
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
