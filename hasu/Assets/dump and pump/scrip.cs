using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class scrip : MonoBehaviourPunCallbacks
{
    
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
  public override void OnJoinedLobby()
   {
       SceneManager.LoadScene(0);
   }


    // Update is called once per frame
    void Update()
    {
      
    }
}
