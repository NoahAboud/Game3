using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void quit()
    {
        Application.Quit();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
   
}
