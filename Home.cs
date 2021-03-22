using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Home : MonoBehaviour
{

    public string levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //options

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
