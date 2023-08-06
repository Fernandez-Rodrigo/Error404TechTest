using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dificulty : MonoBehaviour
{
    [SerializeField] ClickeableObject sphere;
    [SerializeField] ClickeableObject redBox;
    [SerializeField] ClickeableObject yellowBox;
    [SerializeField] ClickeableObject target;
    [SerializeField] ClickeableObject shield;
    [SerializeField] ClickeableObject coin;
    public Dictionary<RangeInt, ClickeableObject> objectsWithPonderance = new Dictionary<RangeInt, ClickeableObject>();
    DifficultySettings difficultySettings;

    void Awake()
    {
        difficultySettings = GameManager.settings;
        objectsWithPonderance.Add(difficultySettings.rangeCoin, coin);
        objectsWithPonderance.Add(difficultySettings.rangeRedBox, redBox);
        objectsWithPonderance.Add(difficultySettings.rangeShield, shield);
        objectsWithPonderance.Add(difficultySettings.rangeShpere, sphere);
        objectsWithPonderance.Add(difficultySettings.rangeTarget, target);
        objectsWithPonderance.Add(difficultySettings.rangeYellowBox, yellowBox);
        SetTimeToDestroy();
    }

    public ClickeableObject SelectObjectToSpawn(int position)
    {
        foreach(RangeInt value in objectsWithPonderance.Keys)
        {
           if(position >= value.start && position<= value.end)
            {
                return objectsWithPonderance[value];
            }
        }
        return null;
    }

    private void SetTimeToDestroy()
    {
        foreach(ClickeableObject objects in objectsWithPonderance.Values)
        {
            objects.SetTimeToDestroy(difficultySettings.spawnTime);
        }
    }

    public float SpawnTime()
    {
       return difficultySettings.spawnTime;
    }  
    
    public ClickeableObject GetCoin()
    {
        return coin;
    }

    public ClickeableObject GetTarget()
    {
        return target;
    }

    public int SpawnProbability() 
    {
        return difficultySettings.spawnProbability;

    }
}
