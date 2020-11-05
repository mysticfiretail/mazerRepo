using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform SpawnPointM;
    public GameObject playerPrefab;

    
    void respawn()
    {
        Instantiate(playerPrefab, SpawnPointM.position, SpawnPointM.rotation);
    }
}
