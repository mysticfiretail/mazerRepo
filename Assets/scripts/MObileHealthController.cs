using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MObileHealthController : MonoBehaviour
{
    public float playerHealth;
    public GameObject[] cornSprite;

    [SerializeField] private Text HealthText;

    private void Start()
    {
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        HealthText.text = playerHealth.ToString("0");
    }

    void FixedUpdate()
    {
        if (playerHealth < 1)
        {
            cornSprite[0].SetActive(false);
            SceneManager.LoadScene("GameOver");
        }
        else if (playerHealth < 2)
        {
            cornSprite[(1)].SetActive(false);
        }
        else if (playerHealth < 3)
        {
            cornSprite[(2)].SetActive(false);
        }
        else if (playerHealth < 4)
        {
            cornSprite[(3)].SetActive(false);
        }
        else if (playerHealth < 5)
        {
            cornSprite[(4)].SetActive(false);
        }
    }
}
