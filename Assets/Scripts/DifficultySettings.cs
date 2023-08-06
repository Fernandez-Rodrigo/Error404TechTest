using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Difficulty", menuName = "ScriptableObjects/DifficultyConfig")]
public class DifficultySettings : ScriptableObject
{
    public RangeInt rangeShpere;
    public RangeInt rangeCoin;
    public RangeInt rangeYellowBox;
    public RangeInt rangeRedBox;
    public RangeInt rangeShield;
    public RangeInt rangeTarget;
    public float spawnTime;
    public int difficulty;
    public int spawnProbability;
    public float totalTime;
}
