using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatisticsHandler : MonoBehaviour

{
    public GameLength timer;
    public TouchSelectionController score;
     [SerializeField] public TMP_Text text;

    public void Start()
    {
        GUI.enabled = false;
        print(GUI.enabled);
        ShowTime();
    }

    public void ShowTime()
    {
        int minutes = Mathf.FloorToInt(timer.timer / 60F);
        int seconds = Mathf.FloorToInt(timer.timer - minutes * 60);
        if (minutes > 0)
        {
            text.text = "WoW du kek hast in " + minutes.ToString() + " Minuten und " + seconds.ToString() + " Sekunden ," + score.score.ToString() + " Stück Müll gesammelt";


        }
        else { text.text = "WoW du kek hast in " + seconds.ToString() + " Sekunden ," + score.score.ToString() + " Stück Müll gesammelt"; }
    }
}
