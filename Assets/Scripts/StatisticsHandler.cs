using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatisticsHandler : MonoBehaviour

{
    public GameLength timer;
    public ScoreHandler scoreHandler;
    [SerializeField] public TMP_Text text;

    public void Start()
    {
        GUI.enabled = false;
    }

    public void ShowTime()
    {
        //4,8 Mio - 12,7 Mio Tonnen Müll pro Jahr = Mittelwert 8,75 Mio Tonnen, TrashPerMinute = 8,75 Mio/36/24/60 = 16,65 Tonnen
        float trashPerMinute = 16.65f;
        float trashPerSecond = trashPerMinute / 60f;
        int minutes = Mathf.FloorToInt(timer.timer / 60);
        int seconds = Mathf.FloorToInt(timer.timer - minutes * 60);

        if (minutes > 0)
        {
            text.text = "Du hast in " + minutes.ToString() + " Minuten und " + 
                seconds.ToString() + " Sekunden " + scoreHandler.score.ToString() + 
                " Stücke Müll gesammelt. Leider sind in dieser Zeit bis zu " + 
                ((trashPerSecond * seconds) + (trashPerMinute * minutes)).ToString("0.00") +
                " Tonnen mehr Müll im Meer gelandet.";


        }
        else { 
            text.text = "Du hast in " + seconds.ToString() + " Sekunden " + 
                scoreHandler.score.ToString() + 
                " Stücke Müll gesammelt. Leider sind in dieser Zeit bis zu " + 
                ((trashPerSecond * seconds).ToString("0.00")) + " Tonnen mehr Müll im Meer gelandet."; 
        }
    }
}
