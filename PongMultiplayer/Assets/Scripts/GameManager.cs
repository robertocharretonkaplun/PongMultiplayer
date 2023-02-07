using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
  public static GameManager instance;

  [Header("MULTIPLAYER")]
  public bool Multiplayer = false;

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

    DontDestroyOnLoad(instance);
  }

  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void InstantiateObject(string name, Vector3 position, Quaternion quaternion)
  {
    PhotonNetwork.Instantiate(name, position, quaternion);
  }

  public bool AreAllPlayersInGame()
  {
    bool result = false;
    if (PhotonNetwork.PlayerList.Length == 2)
    {
      return true;
    }
    return false;
  }

  public void LoadLocalGame()
  {
    if (Multiplayer == false)
    {
      SceneManager.LoadScene("Local");
    }
  }
}
