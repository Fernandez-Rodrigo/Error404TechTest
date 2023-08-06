using System;
using System.Collections;
using UnityEngine;

public abstract class ClickeableObject : MonoBehaviour
{
    [SerializeField] int pointsGiven;
    [SerializeField] int pointTaken;
    float timeToDestroy;
    public void SetTimeToDestroy(float _timeToDestroy)
    {
        timeToDestroy = _timeToDestroy;
    }
        

    public virtual void OnEnable()
    {
        StartCoroutine(DeactiveObject());
    }

    private IEnumerator DeactiveObject()
    {
        yield return new WaitForSeconds(timeToDestroy);

        LoosePoints();
        this.gameObject.SetActive(false);
    }

    public virtual void OnMouseDown()
    {
        GlobalPoints.points += pointsGiven;
        this.gameObject.SetActive(false);
    }

    void LoosePoints()
    {
        GlobalPoints.points -= pointTaken;
    }
}
