using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Intro");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("SampleScene");
        //StartCoroutine(LoadAsynchronously("Main Scene"));

    }

   
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game End");
    }
}
