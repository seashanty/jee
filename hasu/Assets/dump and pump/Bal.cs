using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

    
public class Bal : MonoBehaviourPunCallbacks
{
   public TMP_Text blueTeamText;

   public TMP_Text redTeamText;
    public int teamBluescore = 0;

    public int teamRedscore = 0; 

    Rigidbody _rigitbody;

    void Start()
    {
        _rigitbody = GetComponent<Rigidbody>();
    }



    private void updatescoreText()
    {
      teamRedscore = (int)PhotonNetwork.CurrentRoom.CustomProperties["redScore"];
      teamBluescore = (int)PhotonNetwork.CurrentRoom.CustomProperties["blueScore"];
       
      redTeamText.text ="team Red:" + teamRedscore;
      redTeamText.text ="team Red:" + teamRedscore;
    }
    
    public override void OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
    {
        updatescoreText();
    }

    void OntriggerEnter(Collider other)
    {
       Vector3 startPoint = new Vector3 (0, 1, 0);

       if(other.tag == "BlueGoal")
       {
         teamRedscore += 1;
         PhotonNetwork.CurrentRoom.SetCustomProperties(new ExitGames.Client.Photon.Hashtable() {{"RedScore", teamRedscore}});
       }

       if(other.tag == "RedGoal")
       {
         teamBluescore += 1;
          PhotonNetwork.CurrentRoom.SetCustomProperties(new ExitGames.Client.Photon.Hashtable() {{"BlueScore", teamBluescore}});
       }
     transform.position = startPoint;
     _rigitbody.velocity = Vector3.zero;
     _rigitbody.angularVelocity = Vector3.zero;

    }
    
        
    
}
