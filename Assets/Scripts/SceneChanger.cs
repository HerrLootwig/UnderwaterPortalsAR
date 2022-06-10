using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
     [SerializeField] private GameObject image;

    public void LoadStatics()
    {
        image.SetActive(true);
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Intro");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Prototyp");
        //StartCoroutine(LoadAsynchronously("Main Scene"));

    }


   
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game End");
    }
}
