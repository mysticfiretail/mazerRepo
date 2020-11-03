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
    public void Update()
    {
        level.IsLevelComplete();
        if (level.levelcomplete == true)
        {
            key.SetActive(true);
        }
        else
        {
            key.SetActive(false);
        }
    }
}
