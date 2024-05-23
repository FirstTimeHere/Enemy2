using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _animator.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            _animator.enabled = true;
        }
    }
}
