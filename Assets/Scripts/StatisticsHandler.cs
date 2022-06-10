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
        
        float trashPerSecond = 2/60f;
        float trashPerMinute = 14f;
        int minutes = Mathf.FloorToInt(timer.timer / 60F);
        int seconds = Mathf.FloorToInt(timer.timer - minutes * 60);
        if (minutes > 0)
        {
            text.text = "WoW du kek hast in " + minutes.ToString() + " Minuten und " + seconds.ToString() + " Sekunden ," + score.score.ToString() + " Stück Müll gesammelt. Das ist ziemlich Schlecht, denn in dieser Zeit sind ca. " + ((trashPerSecond * seconds)+(trashPerMinute * minutes)).ToString("0.00") + " Tonnen mehr Müll im Meer gelandet";


        }
        else { text.text = "WoW du kek hast in " + seconds.ToString() + " Sekunden ," + score.score.ToString() + " Stück Müll gesammelt. Das ist ziemlich Schlecht, denn in dieser Zeit sind ca. "+((trashPerSecond*seconds).ToString("0.00")) +" Tonnen mehr Müll im Meer gelandet"; }
    }
}
