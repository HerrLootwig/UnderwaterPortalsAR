using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLength : MonoBehaviour
{

    public float timer =0f;
    bool timeStarted = true;
    [SerializeField] TMP_Text niceText;

  
    // Update is called once per frame
    void Update()
    {
        if (timeStarted == true)
        {
            timer += Time.deltaTime;
        }

        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        niceText.text = niceTime;
  
    }


}