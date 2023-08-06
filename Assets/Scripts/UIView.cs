using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIView : MonoBehaviour
{
    float timeLeft;
    [SerializeField] TextMeshProUGUI time;
    [SerializeField] TextMeshProUGUI totalPoints;
    bool timerOn;

    private void Awake()
    {
        Debug.Log("EL TIEMPO: " + GameManager.settings.totalTime);
        timeLeft = GameManager.settings.totalTime;
    }

    private void Start()
    {
        GlobalPoints.points = 0;
        timerOn = true;
    }


    private void Update()
    {

        totalPoints.text = GlobalPoints.points.ToString();
        StopTimerWhenWon();

        if (timerOn && timeLeft >0)
        {
            timeLeft -= Time.deltaTime;
            UpdateTimer(timeLeft);
        }
        else
        {
            timerOn = false;
            UpdateTimer(-1f);
            GameManager.LooseCondition();
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        time.text = string.Format("{0:00} : {1:00}", minutes, seconds);

    }

    void StopTimerWhenWon()
    {
        if (GlobalPoints.points >= 100)
            timerOn = false;
    }
}
