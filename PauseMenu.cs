using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;



public class PauseMenu : MonoBehaviour
{

    public static bool gameisPaused = false;

    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameisPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    void Paused()
    {
        //activer notre menu pause / l'afficher 
        pauseMenuUI.SetActive(true);

        // arreter le temps
        Time.timeScale = 0;

        // changer le statut du jeu

        gameisPaused = true ;
        Cursor.visible = true;

        Cursor.lockState = CursorLockMode.Confined;
    }

    public void Resume()
    {
        //activer notre menu pause / l'afficher 
        pauseMenuUI.SetActive(false);

        // arreter le temps
        Time.timeScale = 1;

        // changer le statut du jeu

        gameisPaused = false;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
