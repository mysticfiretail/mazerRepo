using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActivateKey : MonoBehaviour
{
    public GameObject key;
    [SerializeField] private Level level;
    // Start is called before the first frame update
    private void Start()
    {
        key = GameObject.FindGameObjectWithTag("MainKey");
    }

    // Update is called once per frame
    private void Update()
    {
        if (level.levelcomplete == true)
        {
            Debug.Log("Key activate");
            key.SetActive(true);
        }
        else
        {
            Debug.Log(level.levelcomplete);
            key.SetActive(false);
        }
    }
}
