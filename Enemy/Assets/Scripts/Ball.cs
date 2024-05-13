using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Enemy
{
    private Vector3 _rotation = new Vector3(0, 90, 0);

    private void Awake()
    {
        transform.rotation = Quaternion.Euler(_rotation);
    }
}
