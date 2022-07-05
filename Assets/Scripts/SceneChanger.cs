using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private GameObject statistics;
    [SerializeField] private GameObject runtimeLabels;

    public void LoadStatistics()
    {
        statistics.SetActive(true);
        statistics.GetComponent<StatisticsHandler>().ShowTime();
        runtimeLabels.SetActive(false);

    }

    //Logik für Zurück-Button
    public void Back()
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
