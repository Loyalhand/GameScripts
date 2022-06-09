using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saves : MonoBehaviour
{
    public class gameSettings : MonoBehaviour
    {
        private void mainMenu()
        {
            SceneManager.LoadScene("Title");
        }

    }
}