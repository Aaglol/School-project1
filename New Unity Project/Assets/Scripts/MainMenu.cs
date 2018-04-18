using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void Comingsoon()
    {

    }


    public void Settings()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
}
