using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
  public int playerCount;
  public GameObject Player;
  // Start is called before the first frame update
  void Start()
  {
    if (PhotonNetwork.PlayerList.Length == 1 )
    {
      PhotonNetwork.Instantiate(Player.name, new Vector3(-9.2f, 0f, 0f), Quaternion.identity);
    }
    else
    {
      PhotonNetwork.Instantiate(Player.name, new Vector3(9.2f, 0f, 0f), Quaternion.identity);
    }
  }

  // Update is called once per frame
  void Update()
  {
    playerCount = PhotonNetwork.PlayerList.Length;
  }
}
