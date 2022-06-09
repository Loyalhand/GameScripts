using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("GameSaves");
    }

    public void setGame()
    {
        SceneManager.LoadScene("Settings");
    }

    public void exitGame()
    {
        Debug.Log("Bye");
        Application.Quit();
    }
}
