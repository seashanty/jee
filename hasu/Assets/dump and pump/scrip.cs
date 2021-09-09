using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using photon.Pun;
using UnityEngine.SceneManagement;

public class scrip : MonoBehaviour : MonoBehaviourPunCallbacks
{
    
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void onconnectedtomaster()
    {
        photonnetwork.joinlobby();
    }
  public override void onjoinedlobby()
   {
       SceneManager.LoadScene("0");
   }


    // Update is called once per frame
    void Update()
    {
      
    }
}
