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
            playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene(sceneToLoad);
        }
    

      if (keyType == key.KeyType.green)
        {
            SceneManager.LoadScene(sceneToLoad);
        }

        if (keyType == key.KeyType.blue)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

}
