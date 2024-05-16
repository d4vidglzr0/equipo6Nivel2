using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public static GameManager Instance { get; private set; }
    public int gunAmmo = 10;
    public Text ammoText;
    public Text healthText;
    public int health = 100;
    private void Awake()  
    {
       Instance = this;
    }

    private void Update()
    {
        ammoText.text = gunAmmo.ToString();
        healthText.text = health.ToString();
    }

    public void LoseHealth (int healhtToReduce)
    {
        health -= healhtToReduce;
        CheckHealth();
    }



    public void CheckHealth ()// respawn
    {
        if (health <= 0)
        {
            Debug.Log("Has muerto");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}

