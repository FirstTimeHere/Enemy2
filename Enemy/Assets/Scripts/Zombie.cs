using UnityEngine;

public class Zombie : Enemy
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        Mover = GetComponent<EnemyMover>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Mover.Target.gameObject)
        {
            _animator.SetBool("_isItTarget", true);
        }
        else
        {
            _animator.SetBool("_isItTarget", false);
        }
    }
}
