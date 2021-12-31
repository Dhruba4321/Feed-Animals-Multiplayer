using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject player;

    public float minX=-15;
    public float maxX=15;
    public float minZ=-9;
    public float maxZ=9;

    private void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX),0,Random.Range(minZ,maxZ));
        PhotonNetwork.Instantiate(player.name, randomPosition, Quaternion.identity);
    }

}
