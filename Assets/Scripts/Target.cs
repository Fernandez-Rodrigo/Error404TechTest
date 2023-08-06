using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : ClickeableObject
{
    public System.Action targetDestroyed;

    public override void OnMouseDown()
    {
        targetDestroyed();
        base.OnMouseDown();
    }
}
