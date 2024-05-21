using UnityEngine;

[RequireComponent(typeof(Target))]
public class TargetMover : MonoBehaviour
{
    private float _speed = 0.5f;

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
