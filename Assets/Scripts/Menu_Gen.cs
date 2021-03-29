using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Gen : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
        
    }

    public void StartGame()
    {
        
        SceneManager.LoadScene("Dummy Level");
    }

    public void Return()
    {
        
        SceneManager.LoadScene("Main Menu");
    }

}
