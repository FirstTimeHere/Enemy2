using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Enemy
{
    protected override void GetVisionTarget()
    {
        base.GetVisionTarget();
    }

    private void Update()
    {
        GetVisionTarget();
    }
}
