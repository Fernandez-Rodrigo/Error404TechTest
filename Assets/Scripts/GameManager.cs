using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static DifficultySettings settings;
    
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        WinCondition();
    }

    public void SetDifficulty(DifficultySettings _settings)
    {
        settings = _settings;
        SpawnConditions();
        Debug.Log("EL TIEMPO EN MANAGER: " + settings.totalTime);
    }

    public void WinCondition()
    {
        if(GlobalPoints.points >= 100 && SceneManager.GetActiveScene().name != "WinScene")
        {
            Changescene.WinScene();
            GlobalPoints.points = 0;
        }
    }

    public static void LooseCondition()
    {
        if(GlobalPoints.points < 100 && SceneManager.GetActiveScene().name != "LooseScene")
          Changescene.LooseScreen();
    }

    private void SpawnConditions()
    {
        if(settings.difficulty == 0)
        {
            settings.rangeCoin = new RangeInt(0, 19);
            settings.rangeRedBox = new RangeInt(20, 9);
            settings.rangeShield = new RangeInt(30, 9);
            settings.rangeShpere = new RangeInt(40, 19);
            settings.rangeTarget = new RangeInt(60, 9);
            settings.rangeYellowBox = new RangeInt(70, 30);
        }
        else if (settings.difficulty == 1)
        {
            settings.rangeCoin = new RangeInt(0, 20);
            settings.rangeRedBox = new RangeInt(10, 20);
            settings.rangeShield = new RangeInt(20, 10);
            settings.rangeShpere = new RangeInt(30, 10);
            settings.rangeTarget = new RangeInt(50, 20);
            settings.rangeYellowBox = new RangeInt(40, 20);
        }
        else
        {
            settings.rangeCoin = new RangeInt(0, 10);
            settings.rangeRedBox = new RangeInt(10, 30);
            settings.rangeShield = new RangeInt(20, 20);
            settings.rangeShpere = new RangeInt(30, 10);
            settings.rangeTarget = new RangeInt(50, 20);
            settings.rangeYellowBox = new RangeInt(40, 10);
        }
    }

}
