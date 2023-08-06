using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaces : MonoBehaviour
{
    public List<SpaceView> easySpaces; 
    public List<SpaceView> mediumSpaces;

    DifficultySettings settings;

    private void Start()
    {
        settings = GameManager.settings;
        SetSpacesAccordToDifficulty();
    }

    void SetSpacesAccordToDifficulty()
    {
        if(settings.difficulty == 0)
        {
            foreach(SpaceView space in easySpaces)
            {
                space.gameObject.SetActive(false);
            }
        }
        if (settings.difficulty == 1)
        {
            foreach (SpaceView space in mediumSpaces)
            {
                space.gameObject.SetActive(false);
            }
        }
    }

    
}
