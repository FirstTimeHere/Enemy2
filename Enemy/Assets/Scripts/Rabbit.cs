using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rabbit : Enemy
{
    private Vector3 _scaleTouchTarget = new Vector3(0.1f, 0.1f, 0.1f);
    private Vector3 _targetPositionChanged;

    private bool _isTouchTarget;

    protected override void GetVisionTarget(Vector3 targetPosition)
    {
        base.GetVisionTarget(targetPosition);
    }

    private void Update()
    {
        //передать проверку где находится цель
        GetVisionTarget(_targetPositionChanged);

        if (_isTouchTarget)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, _scaleTouchTarget, Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.position == TargetPosition)
        {
            _isTouchTarget = true;
        }
    }
}
