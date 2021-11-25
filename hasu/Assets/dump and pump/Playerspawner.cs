using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Playerspawner : MonoBehaviour
{
    public GameObject playerPrefab;

    public float minX = -10;

    public float maxX = -10;

    public float minZ = -10;

    public float maxZ = -10;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX),Random.Range(minZ, maxZ));
        Vector3 spawnposition = new Vector3(transform.position.x + randomPosition.x,transform.position.y,transform.position.z +randomPosition.y);
        PhotonNetwork.Instantiate(playerPrefab.name, spawnposition, Quaternion.identity );
    }

    // Update is called once per frame
   
}
