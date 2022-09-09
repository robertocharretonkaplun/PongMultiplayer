using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
  public TMP_InputField CreateIF;
  public TMP_InputField JoinIF;

  public void CreateRoom()
  {
    PhotonNetwork.CreateRoom(CreateIF.text);
  }

  public void JoinRoom()
  {
    PhotonNetwork.JoinRoom(JoinIF.text);
  }

  public override void OnJoinedRoom()
  {
    PhotonNetwork.LoadLevel("Game");
  }
}
