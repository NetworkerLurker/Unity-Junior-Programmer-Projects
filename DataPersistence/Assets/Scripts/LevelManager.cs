using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("main");
    }

    public static void Quit()
    {
        Application.Quit();
    }
}
