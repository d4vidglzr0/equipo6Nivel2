using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject pausePanel;
    private bool isGamePaused = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            isGamePaused = !isGamePaused;
            PauseGame();    
        }
        
    }

    public void PauseGame()
    {
        if (!isGamePaused)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);

        }
    }
}
