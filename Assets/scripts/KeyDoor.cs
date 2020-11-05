using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDoor : MonoBehaviour
{

    [SerializeField] private key.KeyType keyType;
    public string sceneToLoad;
    public Vector2 playerPosition;
    public vectorValue playerStorage;
    public NewPlayerMov positionPlayer;
  //  public finalKey keyActivate; 

    public key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenDoor(key.KeyType keyType)
    {
       

      //  gameObject.SetActive(false);
     if (keyType == key.KeyType.red)
        {
            //setPlayerCor();
           // playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene(3);
            LevelManager.instance.mmSpawnPoint();
        }
    

      if (keyType == key.KeyType.green)
        {
            SceneManager.LoadScene(4);
        }

        if (keyType == key.KeyType.blue)
        {
           // keyActivate.spawnFinalKey();
            SceneManager.LoadScene(2);
           
        }

        if (keyType == key.KeyType.bxRoom)
        {
            SceneManager.LoadScene(2);
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0.46f, 10.5f, 0);
        }

        if (keyType == key.KeyType.rRoom)
        {
            SceneManager.LoadScene("WIN");
        }
    }

}
