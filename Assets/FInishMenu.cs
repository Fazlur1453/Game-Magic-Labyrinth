using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FInishMenu : MonoBehaviour
{
    

    public void MainMenu()
    {
        
        SceneManager.LoadScene("Main Menu");
        
    }

    public void Next()
    {
        
       SceneManager.LoadScene("Level 2");
        
    }
}
