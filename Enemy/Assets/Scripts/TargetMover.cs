using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Target))]
public class TargetMover : MonoBehaviour
{
    private float _speed = 0.5f;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
