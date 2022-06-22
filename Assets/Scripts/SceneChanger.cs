using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private GameObject statistics;
    [SerializeField] private GameObject runtimeLabels;

    public void LoadStatics()
    {
        statistics.SetActive(true);
        statistics.GetComponent<StatisticsHandler>().ShowTime();
        runtimeLabels.SetActive(false);

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

    public void back()
    {
        statistics.SetActive(false);
        runtimeLabels.SetActive(true);
    }


   
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game End");
    }
}
