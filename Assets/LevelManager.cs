using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{


    #region Singleton

    public static LevelManager instance;

    private void Awake()
    {


        if (playerPrefab == null)
        {
            playerPrefab = GameObject.FindGameObjectWithTag("Player");
        }

    }

    #endregion

    public Transform rrSpawn;
    public Transform mm1Spawn;
    public Transform mm2Spawn;
    public Transform mm3Spawn;
    public Transform brSpawn;

    public GameObject playerPrefab;

 
    public void mmSpawnPoint()
    {

        playerPrefab.transform.position = new Vector3(mm1Spawn.transform.position.x, mm1Spawn.transform.position.y, 0);
 
    }

    public void rrSpawnPoint()
    {

        playerPrefab.transform.position = rrSpawn.transform.position;

    }

    public void rrmSpawnPoint()
    {

        playerPrefab.transform.position = mm2Spawn.transform.position;

    }

    public void brSpawnPoint()
    {

        playerPrefab.transform.position = brSpawn.transform.position;

    }
}
