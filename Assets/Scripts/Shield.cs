using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : ClickeableObject
{
    int counter;

    public override void OnEnable()
    {
        counter = 0;
        base.OnEnable();
    }

    public override void OnMouseDown()
    {
        counter++;

        if(counter >= 5)
        base.OnMouseDown();
    }
}
