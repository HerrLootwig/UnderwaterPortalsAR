using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLength : MonoBehaviour
{

    public float timer =0f;
    bool timeStarted = true;
    public GameObject panel;
    
    void OnGUI()
    {
        GUI.enabled = true;
        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        if (panel.active)
        {
            GUI.Label(new Rect(10, 100, 250, 100), "");
        }
        else
        {
            GUI.Label(new Rect(10, 100, 250, 100), niceTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (timeStarted == true)
        {
            timer += Time.deltaTime;
        }
  
    }


}