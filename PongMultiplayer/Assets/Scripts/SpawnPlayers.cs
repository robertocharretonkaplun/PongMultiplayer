using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
  public int playerCount;
  public GameObject Player;
  public GameObject Parent;
  // Start is called before the first frame update
  void Start()
  {
    if (PhotonNetwork.PlayerList.Length == 1)
    {
      var obj = PhotonNetwork.Instantiate(Player.name, new Vector3(-7.5f, 0f, 0f), Quaternion.identity);
      //obj.transform.parent = Parent.transform;
    }
    else
    {
      var obj = PhotonNetwork.Instantiate(Player.name, new Vector3(7.5f, 0f, 0f), Quaternion.identity);
      //obj.transform.parent = Parent.transform;
    }

  }

  // Update is called once per frame
  void Update()
  {
    playerCount = PhotonNetwork.PlayerList.Length;
  }
}
