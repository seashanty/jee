using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{

 public TMP_InputField createInput;
 public TMP_InputField joinInput;

    public void CreateRoom()
{
 RoomOptions roomOptions = new RoomOptions();
 ExitGames.Client.Photon.Hashtable roomcustomProps = new ExitGames.Client.Photon.Hashtable();
 roomcustomProps.Add("RedScore",0);
 roomcustomProps.Add("BlueScore",0);
 roomOptions.CustomRoomProperties = roomcustomProps;
 PhotonNetwork.CreateRoom(createInput.text,roomOptions);
}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
